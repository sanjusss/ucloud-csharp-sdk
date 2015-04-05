namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取监控数据
    ///     <para>
    ///     http://docs.ucloud.cn/api/umon/get_metric.html
    ///     </para>
    /// </summary>
    public partial class GetMetricRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "GetMetric";

        /// <summary>
        /// API名称
        ///     <para>
        ///     GetMetric
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }  
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 监控指标名称 
        ///     <para>
        ///     监控指标名称
        ///     </para>                 
        /// </summary>
        public NList MetricName { get; set; }

        /// <summary>
        /// 与监控指标相关的资源ID 
        ///     <para>
        ///     如主机，或其他产品，长度[1, 255]
        ///     </para>                 
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源类型 
        ///     <para>
        ///     资源类型，长度[1, 255]
        ///     </para>                 
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// 单位秒 
        ///     <para>
        ///     默认一个小时
        ///     </para>                 
        /// </summary>
        public int? TimeRange { get; set; }

        /// <summary>
        /// unix timestamp                
        /// </summary>
        public int? BeginTime { get; set; }

        /// <summary>
        /// unix timestamp                
        /// </summary>
        public int? EndTime { get; set; }

        /// <summary>
        /// 实例化 <see cref="GetMetricRequest"/> 对象.
        /// </summary>
        /// <param name="region">数据中心.</param>
        /// <param name="metricName">监控指标名称.</param>
        /// <param name="resourceId">与监控指标相关的资源ID.</param>
        /// <param name="resourceType">资源类型.</param>
        public GetMetricRequest(string region, NList metricName, string resourceId, string resourceType)
        {
            Region = region;
            MetricName = metricName;
            ResourceId = resourceId;
            ResourceType = resourceType;
        }

    }
}
