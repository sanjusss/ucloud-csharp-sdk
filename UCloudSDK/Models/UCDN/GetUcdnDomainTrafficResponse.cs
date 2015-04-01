using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名流量使用信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_domain_traffic.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnDomainTrafficResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      GetUcdnDomainTrafficResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 流量实例表 
        ///     <para>
        ///     具体结构见 TrafficSet
        ///     </para>                 
        /// </summary>
        public List<GetUcdnDomainTrafficSet> TrafficSet { get; set; }

    }
}
