namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取监控数据
    ///     <para>
    ///     http://docs.ucloud.cn/api/umon/get_metric.html
    ///     </para>
    /// </summary>
    public partial class GetMetricDataSet
    {
        /// <summary>
        /// 时间戳                
        /// </summary>
        public int Timestamp { get; set; }

        /// <summary>
        /// 监控数据                
        /// </summary>
        public float Value { get; set; }

    }
}
