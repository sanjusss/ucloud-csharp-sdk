namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取域名预取开启状态
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_domain_prefetch_enable.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnDomainPrefetchEnableResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      GetUcdnDomainPrefetchEnableResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 0表示该域名未开启预取 
        ///     <para>
        ///     1表示该域名已开启预取
        ///     </para>                 
        /// </summary>
        public int Enable { get; set; }

    }
}
