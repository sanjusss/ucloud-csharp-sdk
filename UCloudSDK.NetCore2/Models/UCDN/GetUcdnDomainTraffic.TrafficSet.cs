namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名流量使用信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_domain_traffic.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnDomainTrafficSet
    {
        /// <summary>
        /// 流量获取的时间点 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// 查询每日流量总值 
        ///     <para>
        ///     单位：GB
        ///     </para>                 
        /// </summary>
        public float Value { get; set; }

    }
}
