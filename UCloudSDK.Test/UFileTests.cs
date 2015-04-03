using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCloudSDK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UCloudSDK.Models;
using UCloudSDK.Test;

namespace UCloudSDK.Tests
{
    [TestClass()]
    public class UFileTests
    {
        UFile ufile = new UFile(Config.PublicKey, Config.PrivateKey) { Bucket = Config.Bucket };

        /// <summary>
        /// 小文件本地路径
        /// <para>
        /// 小于4M
        /// </para>
        /// </summary>
        private string filePath = @"D:\Media\Photo\MinimiseMeCharacter.jpg";
        /// <summary>
        /// 大文件本地路径
        /// <para>
        /// 大于4M
        /// </para>
        /// </summary>
        private string bigfilePath = @"C:\Users\ICY\Desktop\proxy-client-win64\proxy-win64\pdf.pdf";
        /// <summary>
        /// 下载文件保存路径
        /// </summary>
        private string savePath = @"D:\Media\Photo\MinimiseMeCharacter.jpg";
        /// <summary>
        /// 文件在Bucket中的名称
        /// </summary>
        private string key = "SSHHEE.pdf";

        [TestMethod()]
        public void PutFileTest()
        {
            var response = ufile.PutFile(filePath);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void PostFileTest()
        {
            var response = ufile.PostFile(filePath, key, Config.Bucket);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetFileListTest()
        {
            GetFileListRequest entity = new GetFileListRequest(Config.Bucket);
            var response = ufile.GetFileList(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetFileTest()
        {
            var response = ufile.GetFile(key, savePath);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeleteFileTest()
        {
            var response = ufile.DeleteFile(key);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UploadHitTest()
        {
            var response = ufile.UploadHit(filePath, key);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void InitiateMultipartUploadTest()
        {
            var response = ufile.InitiateMultipartUpload(bigfilePath);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void FinishMultipartUploadTest()
        {
            var entity = ufile.InitiateMultipartUpload(bigfilePath, key: key);

            for (int i = 0; i < 100000; i++)
            {
                if (ufile.PartFile.IsLast)
                {
                    break;
                }

                ufile.UploadPart(i);
            }

            var response = ufile.FinishMultipartUpload("SSHHEE.pdf");

            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void AbortMultipartUploadTest()
        {
            var entity = ufile.InitiateMultipartUpload(bigfilePath);
            FileResponse response = new FileResponse();
            List<string> etags = new List<string>();

            for (int i = 0; i < 100000; i++)
            {
                if (i == 1)
                {
                    response = ufile.AbortMultipartUpload(entity);
                    break;
                }

                var result = ufile.UploadPart(bigfilePath, i, entity);
                etags.Add(result.ETag);
            }

            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
