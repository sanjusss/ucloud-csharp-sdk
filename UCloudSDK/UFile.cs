using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using RestSharp;
using RestSharp.Extensions;
using UCloudSDK.Models;

namespace UCloudSDK
{
    /// <summary>
    /// 对象存储
    /// </summary>
    public partial class UFile : UCloud
    {
        /// <summary>
        /// 默认文件操作地址
        /// </summary>
        private string _fileUrl = @"http://{0}.ufile.ucloud.cn";

        /// <summary>
        /// 文件操作地址.
        /// </summary>
        /// <value>
        /// http://{0}.ufile.ucloud.cn
        /// </value>
        public string FileUrl
        {
            get { return _fileUrl; }
            set { _fileUrl = value; }
        }

        /// <summary>
        /// Bucket.
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// 分片文件.
        /// </summary>
        public PartFile PartFile { get; set; }

        /// <summary>
        /// 初始化 <see cref="UFile"/> 类.
        /// </summary>
        public UFile()
        {
        }

        /// <summary>
        /// 初始化 <see cref="UFile"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        public UFile(string publicKey, string privateKey)
            : base(publicKey, privateKey)
        {
        }

        /// <summary>
        /// 初始化 <see cref="UFile"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        /// <param name="baseUrl">API请求地址.</param>
        public UFile(string publicKey, string privateKey, string baseUrl)
            : base(publicKey, privateKey, baseUrl)
        {
        }

        /// <summary>
        /// 放弃分片上传.
        /// </summary>
        /// <param name="response">初始化分片上传的返回对象.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.FileResponse"/></returns>
        public FileResponse AbortMultipartUpload(InitiateMultipartUploadResponse response)
        {
            return AbortMultipartUpload(response.Key, response.UploadId, response.Bucket);
        }

        /// <summary>
        /// 放弃分片上传.
        /// </summary>
        /// <returns>返回对象<see cref="UCloudSDK.Models.FileResponse"/></returns>
        public FileResponse AbortMultipartUpload()
        {
            return AbortMultipartUpload(PartFile.Key, PartFile.UploadId, PartFile.Bucket);
        }

        /// <summary>
        /// 放弃分片上传
        /// </summary>
        /// <param name="key">Bucket中文件名.</param>
        /// <param name="uploadId">本次分片上传的上传Id.</param>
        /// <param name="bucket">Bucket.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.FileResponse"/></returns>
        /// <exception cref="System.Exception"></exception>
        public FileResponse AbortMultipartUpload(string key, string uploadId, string bucket = "")
        {
            PartFile = new PartFile();

            if (bucket.IsNullOrWhiteSpace())
            {
                bucket = Bucket;
            }

            var url = string.Format(FileUrl, bucket);
            Client.BaseUrl = new Uri(url);
            var request = new RestRequest("{key}?uploadId={uploadId}", Method.DELETE);

            request.AddHeader("Authorization", SignRequest(request, bucket, key));
            request.AddUrlSegment("key", key);
            request.AddUrlSegment("uploadId", uploadId);

            return FileExecute(request);
        }

        /// <summary>
        /// 创建Bucket
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.CreateBucketResponse"/></returns>
        public CreateBucketResponse CreateBucket(CreateBucketRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateBucketResponse>(request);
        }

        /// <summary>
        /// 删除Bucket
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DeleteBucketResponse"/></returns>
        public DeleteBucketResponse DeleteBucket(DeleteBucketRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeleteBucketResponse>(request);
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="key">要获取的文件名.</param>
        /// <param name="bucket">Bucket.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DeleteFileResponse"/></returns>
        public DeleteFileResponse DeleteFile(string key, string bucket = "")
        {
            if (key.IsNullOrWhiteSpace())
            {
                throw new Exception("文件名不能为空");
            }

            if (bucket.IsNullOrWhiteSpace())
            {
                bucket = Bucket;
            }
            var url = string.Format(FileUrl, bucket) + "/" + key;
            Client.BaseUrl = new Uri(url);
            var request = new RestRequest(Method.DELETE);

            request.AddHeader("Authorization", SignRequest(request, bucket, key));

            var response = Client.Execute<DeleteFileResponse>(request);
            Client.BaseUrl = new Uri(BaseUrl);

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                response.Data = new DeleteFileResponse();
                response.Data.RetCode = 0;
                response.Data.ErrMsg = "Success";
                response.Data.ETag = response.Headers.GetHeader("ETag");
            }
            else
            {
                if (response.ErrorException != null)
                {
                    const string message = "响应错误，请检查.";
                    throw new ApplicationException(message, response.ErrorException);
                }
                response.Data.XSessionId = response.Headers.GetHeader("X-SessionId");
                response.Data.ContentType = response.Headers.GetHeader("Content-Type");
                response.Data.ContentRange = response.Headers.GetHeader("Content-Range");
                response.Data.ContentLength = Convert.ToInt32(response.Headers.GetHeader("Content-Length"));
            }
            return response.Data;
        }

        /// <summary>
        /// 获取Bucket的描述信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeBucketResponse"/></returns>
        public DescribeBucketResponse DescribeBucket(DescribeBucketRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeBucketResponse>(request);
        }

        /// <summary>
        /// 完成分片上传.
        /// </summary>
        /// <param name="newkey">在Bucket中的新名称.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.FinishMultipartUploadResponse"/></returns>
        public FinishMultipartUploadResponse FinishMultipartUpload(string newkey)
        {

            var etags = "";
            foreach (var etag in PartFile.Etags)
            {
                etags += etag.Value + ",";
            }

            return FinishMultipartUpload(newkey, etags, PartFile.Key, PartFile.UploadId, PartFile.Bucket);
        }

        /// <summary>
        /// 完成分片上传.
        /// </summary>
        /// <param name="newKey">新名称.</param>
        /// <param name="eTags">分片上传返回的ETAG列表.</param>
        /// <param name="response">初始化分片上传的返回对象.</param>
        /// <returns></returns>
        public FinishMultipartUploadResponse FinishMultipartUpload(string newKey, string eTags,
            InitiateMultipartUploadResponse response)
        {
            return FinishMultipartUpload(newKey, eTags, response.Key, response.UploadId, response.Bucket);
        }

        /// <summary>
        /// 完成分片上传
        /// </summary>
        /// <param name="newKey">新文件名.</param>
        /// <param name="eTags">分片ETags使用,连接后的字符串.</param>
        /// <param name="key">在Bucket中名称.</param>
        /// <param name="uploadId">本次分片上传的ID.</param>
        /// <param name="bucket">Bucket.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.FinishMultipartUploadResponse"/></returns>
        /// <exception cref="System.ApplicationException"></exception>
        /// <exception cref="System.Exception"></exception>
        public FinishMultipartUploadResponse FinishMultipartUpload(string newKey, string eTags, string key, string uploadId, string bucket = "")
        {
            PartFile = new PartFile();

            if (bucket.IsNullOrWhiteSpace())
            {
                bucket = Bucket;
            }

            var url = string.Format(FileUrl, bucket);
            Client.BaseUrl = new Uri(url);
            var request = new RestRequest("{key}?uploadId={uploadId}&newKey={newKey}", Method.POST);
            request.AddHeader("Authorization", SignRequest(request, bucket, key));
            request.AddUrlSegment("key", key);
            request.AddUrlSegment("newKey", newKey);
            request.AddUrlSegment("uploadId", uploadId);


            request.AddParameter("", Encoding.Default.GetBytes(eTags), ParameterType.RequestBody);

            var response = Client.Execute<FinishMultipartUploadResponse>(request);
            Client.BaseUrl = new Uri(BaseUrl);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                response.Data.RetCode = 0;
                response.Data.ErrMsg = "Success";
                response.Data.ETag = response.Headers.GetHeader("ETag");
            }
            else
            {
                if (response.ErrorException != null)
                {
                    const string message = "响应错误，请检查.";
                    throw new ApplicationException(message, response.ErrorException);
                }
                response.Data.XSessionId = response.Headers.GetHeader("X-SessionId");
                response.Data.ContentType = response.Headers.GetHeader("Content-Type");
                response.Data.ContentLength = Convert.ToInt32(response.Headers.GetHeader("Content-Length"));
            }
            return response.Data;
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="key">要获取的文件名.</param>
        /// <param name="path">文件保存路径.</param>
        /// <param name="bucket">Bucket.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.GetFileResponse"/></returns>
        /// <exception cref="System.Exception">文件名不能为空</exception>
        public GetFileResponse GetFile(string key, string path = "", string bucket = "")
        {
            if (key.IsNullOrWhiteSpace())
            {
                throw new Exception("文件名不能为空");
            }
            if (path.IsNullOrWhiteSpace())
            {
                path = key;
            }
            if (bucket.IsNullOrWhiteSpace())
            {
                bucket = Bucket;
            }
            var url = string.Format(FileUrl, bucket) + "/" + key;
            Client.BaseUrl = new Uri(url);
            var request = new RestRequest(Method.GET);

            request.AddHeader("Authorization", SignRequest(request, bucket, key));

            var response = Client.Execute<GetFileResponse>(request);
            Client.BaseUrl = new Uri(BaseUrl);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                response.Data = new GetFileResponse();
                response.Data.RetCode = 0;
                response.Data.ErrMsg = "Success";
                response.Data.ETag = response.Headers.GetHeader("ETag");
                try
                {
                    response.RawBytes.SaveAs(path);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            else
            {
                if (response.ErrorException != null)
                {
                    const string message = "响应错误，请检查.";
                    throw new ApplicationException(message, response.ErrorException);
                }
                response.Data.XSessionId = response.Headers.GetHeader("X-SessionId");
                response.Data.ContentType = response.Headers.GetHeader("Content-Type");
                response.Data.ContentRange = response.Headers.GetHeader("Content-Range");
                response.Data.ContentLength = Convert.ToInt32(response.Headers.GetHeader("Content-Length"));
            }
            return response.Data;
        }

        /// <summary>
        /// 获取Bucket的文件列表
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.GetFileListResponse"/></returns>
        public GetFileListResponse GetFileList(GetFileListRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GetFileListResponse>(request);
        }

        /// <summary>
        /// 初始化分片上传
        /// </summary>
        /// <param name="key">上传至Bucket后的文件名.</param>
        /// <param name="filePath">文件路径.</param>
        /// <param name="bucket">Bucket.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.InitiateMultipartUploadResponse"/></returns>
        /// <exception cref="System.ApplicationException"></exception>
        public InitiateMultipartUploadResponse InitiateMultipartUpload(string filePath, string key = "", string bucket = "")
        {
            if (!File.Exists(filePath))
            {
                throw new Exception(string.Format("文件{0}不存在", filePath));
            }

            if (bucket.IsNullOrWhiteSpace())
            {
                bucket = Bucket;
            }

            if (key.IsNullOrWhiteSpace())
            {
                key = Path.GetFileName(filePath);
            }

            var url = string.Format(FileUrl, bucket);
            Client.BaseUrl = new Uri(url);
            var request = new RestRequest("{key}?uploads", Method.POST);
            request.AddUrlSegment("key", key);

            request.AddHeader("Authorization", SignRequest(request, bucket, key));

            var response = Client.Execute<InitiateMultipartUploadResponse>(request);
            Client.BaseUrl = new Uri(BaseUrl);

            if (response.ErrorException != null)
            {
                const string message = "响应错误，请检查.";
                throw new ApplicationException(message, response.ErrorException);
            }
            var entity = response.Data;
            PartFile = new PartFile()
            {
                BlkSize = entity.BlkSize,
                Bucket = entity.Bucket,
                Key = entity.Key,
                UploadId = entity.UploadId,
                FilePath = filePath,
                Etags = new SortedDictionary<int, string>(),
                IsLast = false,
                PartNumber = 0
            };
            return entity;
        }

        /// <summary>
        /// 表单上传文件
        /// </summary>
        /// <param name="filePath">文件路径.</param>
        /// <param name="key">上件后的文件名.默认为文件名称</param>
        /// <param name="bucket">Bucket名称.</param>
        /// <param name="md5">文件MD5.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.FileResponse"/></returns>
        /// <exception cref="System.Exception"></exception>
        public FileResponse PostFile(string filePath, string key = "", string bucket = "", string md5 = "")
        {
            if (!File.Exists(filePath))
            {
                throw new Exception(string.Format("文件{0}不存在", filePath));
            }

            if (bucket.IsNullOrWhiteSpace())
            {
                bucket = Bucket;
            }

            if (key.IsNullOrWhiteSpace())
            {
                key = Path.GetFileName(filePath);
            }

            var url = string.Format(FileUrl, bucket);
            Client.BaseUrl = new Uri(url);
            var request = new RestRequest(Method.POST);

            var mime = filePath.GetMimeType();
            request.AddHeader("Content-Type", mime);

            if (md5.IsNullOrWhiteSpace())
            {
                md5 = filePath.GetMd5().ToLower();
            }
            request.AddHeader("Content-MD5", md5);
            request.AddParameter("FileName", key);
            request.AddParameter("Content-Type", mime);
            request.AddParameter("Authorization", SignRequest(request, bucket, key));

            request.AddFile(key, filePath);

            return FileExecute(request);
        }

        /// <summary>
        /// 普通上传文件
        /// </summary>
        /// <param name="filePath">文件路径.</param>
        /// <param name="key">上件后的文件名.默认为文件名称</param>
        /// <param name="bucket">Bucket名称.</param>
        /// <param name="md5">文件MD5.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.FileResponse"/></returns>
        /// <exception cref="System.Exception"></exception>
        public FileResponse PutFile(string filePath, string key = "", string bucket = "", string md5 = "")
        {
            if (!File.Exists(filePath))
            {
                throw new Exception(string.Format("文件{0}不存在", filePath));
            }
            if (bucket.IsNullOrWhiteSpace())
            {
                bucket = Bucket;
            }

            if (key.IsNullOrWhiteSpace())
            {
                key = Path.GetFileName(filePath);
            }

            var url = string.Format(FileUrl, bucket) + (key == string.Empty ? "" : (@"/" + key));
            Client.BaseUrl = new Uri(url);
            var request = new RestRequest(Method.PUT);


            if (md5.IsNullOrWhiteSpace())
            {
                md5 = filePath.GetMd5().ToLower();
            }
            var mime = filePath.GetMimeType();
            request.AddHeader("Content-Type", mime);
            request.AddHeader("Content-MD5", md5);
            request.AddHeader("Authorization", SignRequest(request, bucket, key));

            request.AddParameter(mime, File.ReadAllBytes(filePath), ParameterType.RequestBody);

            return FileExecute(request);
        }

        /// <summary>
        /// 设置Bucket的属性
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.UpdateBucketResponse"/></returns>
        public UpdateBucketResponse UpdateBucket(UpdateBucketRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UpdateBucketResponse>(request);
        }

        /// <summary>
        /// 秒传
        /// </summary>
        /// <param name="filePath">文件位置.</param>
        /// <param name="key">Bucket中文件的名称.</param>
        /// <param name="bucket">Bucket.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.FileResponse"/></returns>
        /// <exception cref="System.Exception">文件名不能为空</exception>
        /// <exception cref="System.ApplicationException"></exception>
        public FileResponse UploadHit(string filePath, string key = "", string bucket = "")
        {
            if (!File.Exists(filePath))
            {
                throw new Exception(string.Format("文件{0}不存在", filePath));
            }

            if (bucket.IsNullOrWhiteSpace())
            {
                bucket = Bucket;
            }

            if (key.IsNullOrWhiteSpace())
            {
                key = Path.GetFileName(filePath);
            }

            var url = string.Format(FileUrl, bucket);
            Client.BaseUrl = new Uri(url);
            var request = new RestRequest("uploadhit?Hash={Hash}&FileName={FileName}&FileSize={FileSize}", Method.POST);

            request.AddHeader("Authorization", SignRequest(request, bucket, key));
            request.AddUrlSegment("Hash", filePath.GetEtag());
            request.AddUrlSegment("FileName", key);
            request.AddUrlSegment("FileSize", filePath.GetFileLength().ToString());

            return FileExecute(request);
        }
        /// <summary>
        /// 上传文件分片.
        /// </summary>
        /// <returns>返回对象<see cref="UCloudSDK.Models.UploadPartResponse"/></returns>
        public UploadPartResponse UploadPart()
        {
            return UploadPart(PartFile.PartNumber);
        }
        /// <summary>
        /// 上传文件分片.
        /// </summary>
        /// <param name="partNum">分片号码.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.UploadPartResponse"/></returns>
        public UploadPartResponse UploadPart(int partNum)
        {
            return UploadPart(PartFile.FilePath, partNum, PartFile.BlkSize, PartFile.UploadId, PartFile.Key,
                PartFile.Bucket);
        }

        /// <summary>
        /// 上传文件分片.
        /// </summary>
        /// <param name="filePath">文件路径.</param>
        /// <param name="part">分片编号.</param>
        /// <param name="response">初始化分片上传的返回值.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.UploadPartResponse"/></returns>
        public UploadPartResponse UploadPart(string filePath, int part, InitiateMultipartUploadResponse response)
        {
            return UploadPart(filePath, part, response.BlkSize, response.UploadId, response.Key, response.Bucket);
        }

        /// <summary>
        /// 上传文件分片
        /// </summary>
        /// <param name="filePath">文件位置.</param>
        /// <param name="part">分片序号.</param>
        /// <param name="blkSize">分片大小.</param>
        /// <param name="uploadId">分片上传ID.</param>
        /// <param name="key">在Bucket中名称.</param>
        /// <param name="bucket">Bucket.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.UploadPartResponse"/></returns>
        /// <exception cref="System.Exception"></exception>
        /// <exception cref="System.ApplicationException"></exception>
        public UploadPartResponse UploadPart(string filePath, int part, int blkSize, string uploadId, string key = "", string bucket = "")
        {
            if (PartFile.IsLast)
            {
                throw new Exception("所有分片已上传");
            }

            if (!File.Exists(filePath))
            {
                throw new Exception(string.Format("文件{0}不存在", filePath));
            }
            if (bucket.IsNullOrWhiteSpace())
            {
                bucket = Bucket;
            }
            var url = string.Format(FileUrl, bucket);
            Client.BaseUrl = new Uri(url);
            var request = new RestRequest("{key}?uploadId={uploadId}&partNumber={partNumber}", Method.PUT);

            request.AddUrlSegment("key", key);
            request.AddUrlSegment("uploadId", uploadId);
            request.AddUrlSegment("partNumber", part.ToString());

            if (PartFile.Mime.IsNullOrWhiteSpace())
            {
                PartFile.Mime = filePath.GetMimeType();
            }

            request.AddHeader("Content-Type", PartFile.Mime);

            if (PartFile.Md5.IsNullOrWhiteSpace())
            {
                PartFile.Md5 = filePath.GetMd5().ToLower();
            }
            request.AddHeader("Content-MD5", PartFile.Md5);

            if (key.IsNullOrWhiteSpace())
            {
                key = Path.GetFileName(filePath);
            }

            if (PartFile.Auth.IsNullOrWhiteSpace())
            {
                PartFile.Auth = SignRequest(request, bucket, key);
            }
            request.AddHeader("Authorization", PartFile.Auth);

            byte[] partBytes;

            using (var fs = File.OpenRead(filePath))
            {
                var offset = part * blkSize;
                var len = fs.Length - offset;

                if (len < blkSize)
                {
                    PartFile.IsLast = true;
                }
                else
                {
                    len = blkSize;
                }

                partBytes = new byte[len];
                fs.Seek(offset, SeekOrigin.Begin);
                var n = fs.Read(partBytes, 0, (int)len);
                if (n == 0)
                {
                    PartFile.IsLast = true;
                }
            }

            request.AddParameter(PartFile.Mime, partBytes, ParameterType.RequestBody);

            var response = Client.Execute<UploadPartResponse>(request);
            Client.BaseUrl = new Uri(BaseUrl);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                response.Data.RetCode = 0;
                response.Data.ErrMsg = "Success";
                response.Data.ETag = response.Headers.GetHeader("ETag");
                PartFile.Etags.Add(response.Data.PartNumber, response.Data.ETag);
            }
            else
            {
                if (response.ErrorException != null)
                {
                    const string message = "响应错误，请检查.";
                    throw new ApplicationException(message, response.ErrorException);
                }
                response.Data.XSessionId = response.Headers.GetHeader("X-SessionId");
                response.Data.ContentType = response.Headers.GetHeader("Content-Type");
                response.Data.ContentLength = Convert.ToInt32(response.Headers.GetHeader("Content-Length"));
            }
            return response.Data;
        }

        /// <summary>
        /// 执行Filer操作.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.FileResponse"/></returns>
        /// <exception cref="System.ApplicationException"></exception>
        private FileResponse FileExecute(IRestRequest request)
        {
            var response = Client.Execute<FileResponse>(request);
            Client.BaseUrl = new Uri(BaseUrl);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                response.Data = new FileResponse();
                response.Data.RetCode = 0;
                response.Data.ErrMsg = "Success";
                response.Data.ETag = response.Headers.GetHeader("ETag");
            }
            else
            {
                if (response.ErrorException != null)
                {
                    const string message = "响应错误，请检查.";
                    throw new ApplicationException(message, response.ErrorException);
                }
                response.Data.XSessionId = response.Headers.GetHeader("X-SessionId");
                response.Data.ContentType = response.Headers.GetHeader("Content-Type");
                response.Data.ContentRange = response.Headers.GetHeader("Content-Range");
                response.Data.ContentLength = Convert.ToInt32(response.Headers.GetHeader("Content-Length"));
            }
            return response.Data;
        }

        /// <summary>
        /// 对象存储UFile签名.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="bucket">Bucket.</param>
        /// <param name="key">Key.</param>
        /// <returns>签名</returns>
        private string SignRequest(IRestRequest request, string bucket, string key)
        {
            string Authorization = string.Empty;
            string StringToSign = string.Empty;


            Authorization += "UCloud ";
            Authorization += PublicKey;
            Authorization += ":";
            StringToSign = request.Method + "\n" + request.Parameters.GetHeader("Content-MD5") + "\n";
            StringToSign += request.Parameters.GetHeader("Content-Type");
            StringToSign += "\n";
            /*
            StringToSign += DateTime.Now.ToString ();
            */
            StringToSign += "\n";
            StringToSign += request.Parameters.CanonicalizedUCloudHeaders();
            StringToSign += StringHelper.CanonicalizedResource(bucket, key);

            HMACSHA1 hmac = new HMACSHA1(Encoding.ASCII.GetBytes(PrivateKey));
            Byte[] hashValue = hmac.ComputeHash(Encoding.UTF8.GetBytes(StringToSign));
            string Signature = Convert.ToBase64String(hashValue);
            return Authorization + Signature;
        }
    }
}