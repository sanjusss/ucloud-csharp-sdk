namespace UCloudSDK.Models
{
    /// <summary>
    /// 添加SSL证书
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/create_ssl.html
    ///     </para>
    /// </summary>
    public partial class CreateSSLRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateSSL";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateSSL
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// SSL证书的内容                
        /// </summary>
        public string SSLContent { get; set; }

        /// <summary>
        /// SSL证书的名字 
        ///     <para>
        ///     默认值为空
        ///     </para>                 
        /// </summary>
        public string SSLName { get; set; }

        /// <summary>
        /// 所添加的SSL证书类型 
        ///     <para>
        ///     目前只支持0：Pem格式
        ///     </para>                 
        /// </summary>
        public int? SSLType { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateSSLRequest" /> 类.
        /// </summary>
        /// <param name="region">数据中心</param>
        /// <param name="sslName">SSL证书的名字.</param>
        /// <param name="sslcontent">SSL证书的内容</param>
        public CreateSSLRequest(string region,string sslName, string sslcontent)
        {               
            Region = region;
            SSLName = sslName;
            SSLContent = sslcontent;
        }                
    }
}
