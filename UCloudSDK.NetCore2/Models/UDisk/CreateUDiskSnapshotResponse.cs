namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建snapshot快照
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/create_udisk_snapshot.html
    ///     </para>
    /// </summary>
    public partial class CreateUDiskSnapshotResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 快照Id                
        /// </summary>
        public string SnapshotId { get; set; }

    }
}
