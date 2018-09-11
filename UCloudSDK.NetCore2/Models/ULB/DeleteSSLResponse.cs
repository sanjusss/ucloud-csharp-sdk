namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除SSL证书
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/delete_ssl.html
    ///     </para>
    /// </summary>
    public partial class DeleteSSLResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DeleteSSLResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
