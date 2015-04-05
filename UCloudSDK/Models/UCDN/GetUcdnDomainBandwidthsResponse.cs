using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名带宽使用信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_domain_bandwidth.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnDomainBandwidthResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      GetUcdnDomainBandwidthResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 从起始时间到结束时间内所使用的带宽总量 
        ///     <para>
        ///     单位GB
        ///     </para>                 
        /// </summary>
        public float Traffic { get; set; }

        /// <summary>
        /// 带宽流量实例表 
        ///     <para>
        ///     具体结构见 BandwidthSet
        ///     </para>                 
        /// </summary>
        public List<GetUcdnDomainBandwidthSet> BandWidthSet { get; set; }

    }
}
