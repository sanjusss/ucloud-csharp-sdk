namespace UCloudSDK.Models
{
    /// <summary>
    /// 预取文件
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/prefetch_domain_cache.html
    ///     </para>
    /// </summary>
    public partial class PrefetchDomainCacheResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      PrefetchDomainCacheResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
