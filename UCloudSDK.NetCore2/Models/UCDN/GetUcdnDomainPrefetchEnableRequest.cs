namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取域名预取开启状态
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_domain_prefetch_enable.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnDomainPrefetchEnableRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "GetUcdnDomainPrefetchEnable";

        /// <summary>
        /// API名称
        ///     <para>
        ///     GetUcdnDomainPrefetchEnable
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
        /// 实例化 <see cref="GetUcdnDomainPrefetchEnableRequest"/> 类.
        /// </summary>
        /// <param name="domainId">域名ID.</param>
        public  GetUcdnDomainPrefetchEnableRequest(string domainId)
        {
            DomainId = domainId;
        }

    }
}
