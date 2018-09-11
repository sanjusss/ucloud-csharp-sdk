namespace UCloudSDK.Models
{
    /// <summary>
    /// 更新加速域名状态
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/update_ucdn_domain_status.html
    ///     </para>
    /// </summary>
    public partial class UpdateUcdnDomainStatusResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      UpdateUcdnDomainStatusResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
