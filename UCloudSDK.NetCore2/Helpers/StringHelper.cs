using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace UCloudSDK
{
    /// <summary>
    /// string扩展方法
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// 获取文件的MD5值.
        /// </summary>
        /// <param name="file">文件路径.</param>
        /// <returns>文件MD5</returns>
        public static string GetMd5(this string file)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", String.Empty);
                }
            }
        }

        /// <summary>
        /// CanonicalizedResource.
        /// </summary>
        /// <param name="bucket">Bucket.</param>
        /// <param name="key">Key.</param>
        /// <returns>CanonicalizedResource</returns>
        public static string CanonicalizedResource(string bucket, string key)
        {
            return "/" + bucket + "/" + key;
        }

        /// <summary>
        /// 获取base64编码.
        /// </summary>
        /// <param name="text">字符串.</param>
        /// <returns>base64值</returns>
        public static string ToBase64(this string text)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// 获取Url Safe的BASE64编码.
        /// </summary>
        /// <param name="text">字符串.</param>
        /// <returns>
        /// BASE64编码
        /// </returns>
        public static string ToUrlSafeBase64(this string text)
        {
            var base64 = text.ToBase64();
            return base64.TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }

        /// <summary>
        /// base64解码.
        /// </summary>
        /// <param name="text">BASE64编码字符串.</param>
        /// <returns>字符串</returns>
        public static string DecodeBase64(this string text)
        {
            var plainTextBytes = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(plainTextBytes);
        }

        /// <summary>
        /// 将_替换为-.
        /// </summary>
        /// <param name="str">字符串.</param>
        /// <returns>字符串</returns>
        public static string ToHyphen(this string str)
        {
            return str.Replace("_", "-");
        }

        /// <summary>
        /// 计算SHA1.
        /// </summary>
        /// <param name="str">字符串.</param>
        /// <returns>签名值</returns>
        public static string ToSHA1(this string str)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(str));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }


        /// <summary>
        /// 指示指定的字符串是 null、空还是仅由空白字符组成.
        /// </summary>
        /// <param name="str">字符串.</param>
        /// <returns>Bool</returns>
        public static bool IsNullOrWhiteSpace(this string str)
        {
#if NET4
            return string.IsNullOrWhiteSpace(str);
#else
            return String.IsNullOrEmpty(str) || str.Trim().Length == 0;
#endif

        }


        /// <summary>
        /// 获取文件MIME类型.
        /// </summary>
        /// <param name="file">文件路径.</param>
        /// <returns>文件MIME</returns>
        public static string GetMimeType(this string file)
        {
            return MimeHelper.GetType(Path.GetExtension(file));
        }
    }
}
