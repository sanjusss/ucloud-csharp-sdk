using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 短信发送请求对象
    /// </summary>
    public partial class SMSRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "SendSms";

        /// <summary>
        /// API名称
        ///     <para>
        ///     SendSms
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }

        /// <summary>
        /// 号码列表 
        ///     <para>
        ///      Phone.n
        ///     </para>                 
        /// </summary>
        public NList Phone { get; set; }

        /// <summary>
        /// 购买流量的区域 
        ///     <para>
        ///      枚举值为:cn: 国内; abroad: 海外
        ///     </para>                 
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 实例化 <see cref="SMSRequest" /> 类.
        /// </summary>
        /// <param name="phone">号码列表.</param>
        /// <param name="content">短信内容.</param>
        public SMSRequest(NList phone, string content)
        {
            Phone = phone;
            Content = content;
        }
    }
}
