namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取流量信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_traffic.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnTrafficSet
    {
        /// <summary>
        /// 购买流量的区域 
        ///     <para>
        ///      cn: 国内; aboard: 国外
        ///     </para>                 
        /// </summary>
        public string Areacode { get; set; }

        /// <summary>
        /// Areacode区域内总购买流量 
        ///     <para>
        ///      单位GB
        ///     </para>                 
        /// </summary>
        public float TrafficTotal { get; set; }

        /// <summary>
        /// Areacode区域内总剩余流量 
        ///     <para>
        ///      单位GB
        ///     </para>                 
        /// </summary>
        public float TrafficLeft { get; set; }

        /// <summary>
        /// Areacode区域内总使用流量 
        ///     <para>
        ///      单位GB
        ///     </para>                 
        /// </summary>
        public float TrafficUsed { get; set; }

    }
}
