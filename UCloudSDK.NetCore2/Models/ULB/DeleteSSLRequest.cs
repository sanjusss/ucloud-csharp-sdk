namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除SSL证书
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/delete_ssl.html
    ///     </para>
    /// </summary>
    public partial class DeleteSSLRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DeleteSSL";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DeleteSSL
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
        /// SSL证书的ID                
        /// </summary>
        public string SSLId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DeleteSSLRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="sslid">SSL证书的ID</param>                    
        public DeleteSSLRequest(string region, string sslid)
        {               
            Region = region;
            SSLId = sslid;
        }                
    }
}
