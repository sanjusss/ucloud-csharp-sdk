namespace UCloudSDK.Models
{
    /// <summary>
    /// 将SSL证书绑定到VServer
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/bind_ssl.html
    ///     </para>
    /// </summary>
    public partial class BindSSLRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "BindSSL";

        /// <summary>
        /// API名称
        ///     <para>
        ///     BindSSL
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
        /// SSL证书的Id                
        /// </summary>
        public string SSLId { get; set; }

        /// <summary>
        /// 所绑定ULB实例ID                
        /// </summary>
        public string ULBId { get; set; }

        /// <summary>
        /// 所绑定VServer实例ID                
        /// </summary>
        public string VServerId { get; set; }

        /// <summary>
        /// 实例化 <see cref="BindSSLRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="sslid">SSL证书的Id</param>                    
        /// <param name="ulbid">所绑定ULB实例ID</param>                    
        /// <param name="vserverid">所绑定VServer实例ID</param>                    
        public BindSSLRequest(string region, string sslid, string ulbid, string vserverid)
        {               
            Region = region;
            SSLId = sslid;
            ULBId = ulbid;
            VServerId = vserverid;
        }                
    }
}
