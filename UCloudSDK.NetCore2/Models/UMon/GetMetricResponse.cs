using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取监控数据
    ///     <para>
    ///     http://docs.ucloud.cn/api/umon/get_metric.html
    ///     </para>
    /// </summary>
    public partial class GetMetricResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// JSON格式监控数据列表ResponseItem                
        /// </summary>
        public List<string> DataSets { get; set; }

    }
}
