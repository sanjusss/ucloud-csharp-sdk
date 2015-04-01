namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名带宽使用信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_domain_bandwidth.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnDomainBandwidthSet
    {
        /// <summary>
        /// 带宽获取的时间点 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// 具体带宽值 
        ///     <para>
        ///     单位为Mbps。其中查询区间为1天，value的值表示5分钟内的最大带宽值；查询区间为2-4天，value的值表示15分钟内的最大带宽值；查询区间为5-14天，value的值表示3-分钟内的最大带宽值；查询区间为15-30天，value的值为1小时内的带宽最大值。（如果请求参数中Daily为1，则value的值表示1天内的带宽最大值）
        ///     </para>                 
        /// </summary>
        public float Value { get; set; }

    }
}
