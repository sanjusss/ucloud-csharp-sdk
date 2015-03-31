namespace UCloudSDK.Models
{
    /// <summary>
    /// 添加SSL证书
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/create_ssl.html
    ///     </para>
    /// </summary>
    public partial class CreateSSLResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreateSSLResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// SSL证书的Id                
        /// </summary>
        public string ULBId { get; set; }

    }
}
