namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取域名预取任务状态
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/describe_prefetch_cache_task.html
    ///     </para>
    /// </summary>
    public partial class DescribePrefetchCacheTaskRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribePrefetchCacheTask";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribePrefetchCacheTask
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
               
        /// <summary>
        /// 域名ID 
        ///     <para>
        ///     创建加速域名时生成。
        ///     </para>                 
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// 查询的起始时间 
        ///     <para>
        ///     格式为Unix Timestamp。如果有EndTime，BeginTime必须赋值。
        ///     </para>                 
        /// </summary>
        public int? BeginTime { get; set; }

        /// <summary>
        /// 查询的结束时间 
        ///     <para>
        ///     格式为Unix Timestamp。EndTime默认为当前时间，BeginTime默认为当前时间前一天时间。
        ///     </para>                 
        /// </summary>
        public int? EndTime { get; set; }

        /// <summary>
        /// 需要获取的内容刷新的状态 
        ///     <para>
        ///     枚举值：success：成功；wait：等待处理；process：正在处理；failure：失败；unkonw：未知，默认选择所有状态
        ///     </para>                 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 数据偏移量 
        ///     <para>
        ///     默认为0
        ///     </para>                 
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// 返回数据的长度 
        ///     <para>
        ///     默认20。
        ///     </para>                 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribePrefetchCacheTaskRequest"/> 类.
        /// </summary>
        /// <param name="domainId">域名ID.</param>
        public DescribePrefetchCacheTaskRequest(string domainId)
        {
            DomainId = domainId;
        }
    }
}
