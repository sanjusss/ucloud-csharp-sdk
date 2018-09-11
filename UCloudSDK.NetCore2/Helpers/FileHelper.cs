using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace UCloudSDK
{
    /// <summary>
    /// 文件帮助类
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// 分块长度 4*1024*1024
        /// </summary>
        public const int BlockSize = 4194304;

        /// <summary>
        /// 获取文件Etag.
        /// </summary>
        /// <param name="filePath">文件路径.</param>
        /// <returns>ETag</returns>
        public static string GetEtag(this string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new Exception(string.Format("文件{0}不存在", filePath));
            }

            var length = GetFileLength(filePath);

            int blkcnt = (int)Math.Ceiling((double)length / (double)BlockSize);

            var buffer = BitConverter.GetBytes(blkcnt);

            if (length < BlockSize)
            {
                var fileBytes = File.ReadAllBytes(filePath);
                var data = buffer.Concat(fileBytes.GetSha1());

                return data.ToUrlSafeBase64();
            }
            else
            {
                byte[] sha1 = new byte[0];
                using (var fs = File.OpenRead(filePath))
                {
                    for (int i = 0; i < blkcnt; i++)
                    {
                        var len = BlockSize;
                        if (length - BlockSize * i < len)
                        {
                            len = (int)(length - BlockSize * i);
                        }
                        var temp = new byte[len];
                        int n = fs.Read(temp, 0, len);
                        if (n == 0) break;
                        sha1 = sha1.Concat(temp.GetSha1());
                    }
                }
                var data = buffer.Concat(sha1.GetSha1());
                return data.ToUrlSafeBase64();
            }
        }


        /// <summary>
        /// 获取sha1 byte[].
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>SHA1 byte[]</returns>
        public static byte[] GetSha1(this byte[] bytes)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                return sha1.ComputeHash(bytes);
            }
        }

        /// <summary>
        /// 获取Url Safe的BASE64编码.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>BASE64编码</returns>
        public static string ToUrlSafeBase64(this byte[] bytes)
        {
            return Convert.ToBase64String(bytes).TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }

        /// <summary>
        /// 把两个byte[]合并为一个.
        /// </summary>
        /// <param name="bytes">byte[].</param>
        /// <param name="add">byte[].</param>
        /// <returns>byte[]</returns>
        public static byte[] Concat(this byte[] bytes, byte[] add)
        {
            if (bytes.Length == 0)
            {
                return add;
            }
            var buffer = new byte[bytes.Length + add.Length];
            Array.Copy(bytes, 0, buffer, 0, bytes.Length);
            Array.Copy(add, 0, buffer, bytes.Length, add.Length);
            return buffer;
        }

        /// <summary>
        /// 获取文件大小.
        /// </summary>
        /// <param name="filePath">文件路径.</param>
        /// <returns>文件大小</returns>
        public static long GetFileLength(this string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }
    }
}
