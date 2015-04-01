using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取流量信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_traffic.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnTrafficResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      GetUcdnTrafficResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 用户不同区域的流量信息 
        ///     <para>
        ///      具体结构参见TrafficSet部分
        ///     </para>                 
        /// </summary>
        public List<GetUcdnTrafficSet> TrafficSet { get; set; }

    }
}
