using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取域名刷新任务状态
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/describe_refresh_cache_task.html
    ///     </para>
    /// </summary>
    public partial class DescribeRefreshCacheTaskSet
    {
        /// <summary>
        /// 刷新域名                
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// 刷新任务创建的时间 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// 任务状态查询时间 
        ///     <para>
        ///     成功后不再查询。格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public string CheckTime { get; set; }

        /// <summary>
        /// 刷新提交的多条URL                
        /// </summary>
        public List<string> UrlLists { get; set; }

        /// <summary>
        /// 刷新任务的当前状态 
        ///     <para>
        ///     枚举值：success：成功；wait：等待处理；process：正在处理；failure：失败；unkonw：未知
        ///     </para>                 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 刷新任务执行的百分比 
        ///     <para>
        ///     1代表1%，100代表100%
        ///     </para>                 
        /// </summary>
        public int Percent { get; set; }

    }
}
