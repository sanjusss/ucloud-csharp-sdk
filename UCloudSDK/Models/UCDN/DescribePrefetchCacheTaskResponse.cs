using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取域名预取任务状态
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/describe_prefetch_cache_task.html
    ///     </para>
    /// </summary>
    public partial class DescribePrefetchCacheTaskResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      DescribePrefetchCacheTaskResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 返回总条目数                
        /// </summary>
        public string TotalCount { get; set; }

        /// <summary>
        /// 预取任务信息 
        ///     <para>
        ///     具体结构见 TaskSet
        ///     </para>                 
        /// </summary>
        public List<DescribePrefetchCacheTaskSet> TaskSet { get; set; }

    }
}
