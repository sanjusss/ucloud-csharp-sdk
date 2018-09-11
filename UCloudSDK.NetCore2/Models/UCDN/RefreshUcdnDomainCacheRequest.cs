namespace UCloudSDK.Models
{
    /// <summary>
    /// 刷新加速缓存
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/refresh_ucdn_domain_cache.html
    ///     </para>
    /// </summary>
    public partial class RefreshUcdnDomainCacheRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "RefreshUcdnDomainCache";

        /// <summary>
        /// API名称
        ///     <para>
        ///     RefreshUcdnDomainCache
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
               
        /// <summary>
        /// 域名ID 
        ///     <para>
        ///     创建加速域名时生成。
        ///     </para>                 
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// 刷新类型 
        ///     <para>
        ///     file代表文件刷新，dir代表路径刷新
        ///     </para>                 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// URL列表
        ///     <para>
        ///     一次最多提交30个。必须以”http://域名/”开始。目录要以”/”结尾，如刷新目录a下所有文件，格式为：http://abc.ucloud.cn/a/；如刷新文件目录a下面所有img.png文件，格式为http://abc.ucloud.cn/a/img.png。请正确提交需要刷新的域名
        ///     </para>                 
        /// </summary>
        public NList UrlList { get; set; }

        /// <summary>
        /// 实例化 <see cref="RefreshUcdnDomainCacheRequest"/> 类.
        /// </summary>
        /// <param name="domainId">域名ID.</param>
        /// <param name="type">刷新类型.</param>
        /// <param name="urlList">URL列表.</param>
        public RefreshUcdnDomainCacheRequest(string domainId, string type, NList urlList)
        {
            DomainId = domainId;
            Type = type;
            UrlList = urlList;
        }
    }
}
