namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建加速域名
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/create_ucdn_domain.html
    ///     </para>
    /// </summary>
    public partial class CreateUcdnDomainResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      CreateUcdnDomainResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 创建域名对应的域名ID 
        ///     <para>
        ///     后续获取域名相关数据的操作均需要使用该ID
        ///     </para>                 
        /// </summary>
        public string DomainId { get; set; }

    }
}
