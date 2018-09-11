namespace UCloudSDK.Models
{
    /// <summary>
    /// 刷新加速缓存
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/refresh_ucdn_domain_cache.html
    ///     </para>
    /// </summary>
    public partial class RefreshUcdnDomainCacheResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      RefreshUcdnDomainCacheResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
