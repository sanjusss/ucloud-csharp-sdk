namespace UCloudSDK.Models
{
    /// <summary>
    /// 销毁Snapshot
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/delete_udisk_snapshot.html
    ///     </para>
    /// </summary>
    public partial class DeleteUDiskSnapshotResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
