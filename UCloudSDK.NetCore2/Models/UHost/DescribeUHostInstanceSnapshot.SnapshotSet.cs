namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取已经存在的UHost实例的存储快照列表。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_uhost_instance_snapshot.html
    ///     </para>
    /// </summary>
    public partial class DescribeUHostInstanceSnapshotSet
    {
        /// <summary>
        /// 快照名称                
        /// </summary>
        public string SnapshotName { get; set; }

        /// <summary>
        /// 快照制作时间                
        /// </summary>
        public string SnapshotTime { get; set; }

    }
}
