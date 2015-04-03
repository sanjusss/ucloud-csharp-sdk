using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 对象存储UFile操作的返回对象
    /// </summary>
    public partial class FileResponse : ResponseHeader
    {
        /// <summary>
        /// 执行结果代码
        ///     <para>
        ///     执行成功与否，0 表示成功，其他值则为错误代码.
        ///     </para>
        /// </summary>
        public int RetCode { get; set; }

        /// <summary>
        /// 消息.
        /// </summary>
        public string ErrMsg { get; set; }
    }
}
