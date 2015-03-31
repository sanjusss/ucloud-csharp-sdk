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
        /// API名称
        ///     <para>
        ///     GetUcdnDomainPrefetchEnable
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "GetUcdnDomainPrefetchEnable";
            }
        }  
               
        /// <summary>
        /// 域名ID 
        ///     <para>
        ///     创建加速域名时生成。
        ///     </para>                 
        /// </summary>
        public string DomainId { get; set; }

    }
}
