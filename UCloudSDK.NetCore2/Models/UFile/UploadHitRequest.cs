namespace UCloudSDK.Models
{
    /// <summary>
    /// 秒传
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/upload_hit.html
    ///     </para>
    /// </summary>
    public partial class UploadHitRequest
    {
        /// <summary>
        /// 待上传文件的ETag 
        ///     <para>
        ///     详见ETag生成文档
        ///     </para>                 
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Bucket中文件的名称                
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 待上传文件的大小                
        /// </summary>
        public string FileSize { get; set; }

        /// <summary>
        /// 实例化 <see cref="UploadHitRequest"/> 类.
        /// </summary>
        /// <param name="hash">待上传文件的ETag</param>                    
        /// <param name="filename">Bucket中文件的名称</param>                    
        /// <param name="filesize">待上传文件的大小</param>                    
        public UploadHitRequest(string hash, string filename, string filesize)
        {               
            Hash = hash;
            FileName = filename;
            FileSize = filesize;
        }                
    }
}
