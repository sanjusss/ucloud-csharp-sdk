using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取UDisk快照
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/describe_udisk_snapshot.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDiskSnapshotResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// JSON 格式的Snapshot列表 
        ///     <para>
        ///      详细参见ResponseItem
        ///     </para>                 
        /// </summary>
        public List<string> DataSet { get; set; }

        /// <summary>
        /// 根据过滤条件得到的总数                
        /// </summary>
        public int TotalCount { get; set; }

    }
}
