using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取已经存在的UHost实例的存储快照列表。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_uhost_instance_snapshot.html
    ///     </para>
    /// </summary>
    public partial class DescribeUHostInstanceSnapshotResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     TerminateUHostInstanceResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

        /// <summary>
        /// UHost快照列表 
        ///     <para>
        ///     详细参数可见下面SnapshotSet
        ///     </para>                 
        /// </summary>
        public List<DescribeUHostInstanceSnapshotSet> SnapshotSet { get; set; }

    }
}
