namespace UCloudSDK.Models
{
    /// <summary>
    /// 更新加速域名配置
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/update_ucdn_domain.html
    ///     </para>
    /// </summary>
    public partial class UpdateUcdnDomainRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UpdateUcdnDomain";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UpdateUcdnDomain
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
        /// 源站IP 
        ///     <para>
        ///     即cdn服务器回源访问的IP地址。支持多个源站IP。多个源站IP可以表述为：SourceIps.0=1.1.1.1，SourceIps.1=2.2.2.2
        ///     </para>                 
        /// </summary>
        public NList SourceIp { get; set; }

        /// <summary>
        /// 测试url 
        ///     <para>
        ///     用于域名创建加速时的测试。
        ///     </para>                 
        /// </summary>
        public string TestUrl { get; set; }

        /// <summary>
        /// CDN加速区域 
        ///     <para>
        ///     目前区域代表有：cn：国内；abroad：国外。可选择多个区域，表述为：”Areacodes.0=cn, Areacodes.1=aboard”，表示同时使用国内和海外节点
        ///     </para>                 
        /// </summary>
        public NList Areacode { get; set; }

        /// <summary>
        /// 加速成功后需要缓存在节点服务器的静态文件类型 
        ///     <para>
        ///     动态文件不支持缓存。多个文件类型，请使用：”CacheFileTypes.0=zip, CacheFileTypes.1=txt”，依赖于CacheTel参数
        ///     </para>                 
        /// </summary>
        public NList CacheFileType { get; set; }

        /// <summary>
        /// 需要缓存的文件或路径的URL 
        ///     <para>
        ///     URL支持模糊匹配，不支持正则表达式。
        ///     </para>                 
        /// </summary>
        public NList CacheUrl { get; set; }

        /// <summary>
        /// 缓存文件或路径需要缓存的时间 
        ///     <para>
        ///     单位：秒
        ///     </para>                 
        /// </summary>
        public int? CacheTtl { get; set; }

        /// <summary>
        /// 不需要缓存的文件或路径 
        ///     <para>
        ///     格式同CacheUrls
        ///     </para>                 
        /// </summary>
        public NList NoCacheUrl { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdateUcdnDomainRequest"/> 对象.
        /// </summary>
        /// <param name="domainId">用于加速的域名.</param>
        public UpdateUcdnDomainRequest(string domainId)
        {
            DomainId = domainId;
        } 

    }
}
