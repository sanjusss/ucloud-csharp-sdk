using System;
using System.Text;

namespace UCloudSDK
{
    /// <summary>
    /// string扩展方法
    /// </summary>
    public static class StringHelper
    {
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
        /// 将_替换为-.
        /// </summary>
        /// <param name="str">字符串.</param>
        /// <returns>字符串</returns>
        public static string ToHyphen(this string str)
        {
            return str.Replace("_", "-");
        }
    }
}
