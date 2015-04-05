namespace UCloudSDK.Models
{
    /// <summary>
    /// 预取文件
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/prefetch_domain_cache.html
    ///     </para>
    /// </summary>
    public partial class PrefetchDomainCacheRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "PrefetchDomainCache";

        /// <summary>
        /// API名称
        ///     <para>
        ///     PrefetchDomainCache
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
        /// URL列表 
        ///     <para>
        ///     一次最多提交10个，必须以”http://域名/”开始。目录要以”/”结尾，如刷新目录a下所有文件，格式为：http://abc.ucloud.cn/a/；如刷新文件目录a下面所有img.png文件，格式为http://abc.ucloud.cn/a/img.png。请正确提交需要刷新的域名（点播，下载只支持每次预取一个）
        ///     </para>                 
        /// </summary>
        public NList UrlList { get; set; }

        /// <summary>
        /// 大文件下载、点播支持文件的md5校验                
        /// </summary>
        public string Md5 { get; set; }

        /// <summary>
        /// 实例化 <see cref="PrefetchDomainCacheRequest"/> 类.
        /// </summary>
        /// <param name="domainId">域名ID.</param>
        /// <param name="urlList">URL列表.</param>
        public PrefetchDomainCacheRequest(string domainId, NList urlList)
        {
            DomainId = domainId;
            UrlList = urlList;
        }
    }
}
