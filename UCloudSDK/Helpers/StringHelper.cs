using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCloudSDK.Models;

namespace UCloudSDK
{
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
