namespace UCloudSDK.Models
{
    /// <summary>
    /// 将SSL证书绑定到VServer
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/bind_ssl.html
    ///     </para>
    /// </summary>
    public partial class BindSSLResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     BindSSLResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// SSL证书的Id                
        /// </summary>
        public string ULBId { get; set; }

    }
}
