namespace UCloudSDK.Models
{
    /// <summary>
    /// 从快照创建UDisk克隆
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/clone_udisk_snapshot.html
    ///     </para>
    /// </summary>
    public partial class CloneUDiskSnapshotResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 创建UDisk Id                
        /// </summary>
        public string UDiskId { get; set; }

    }
}
