namespace UCloudSDK.Models
{
    /// <summary>
    /// 销毁Snapshot
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/delete_udisk_snapshot.html
    ///     </para>
    /// </summary>
    public partial class DeleteUDiskSnapshotRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     DeleteUDiskSnapshot
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "DeleteUDiskSnapshot";
            }
        }  
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///      参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 快照Id                
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DeleteUDiskSnapshotRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="snapshotid">快照Id</param>                    
        public DeleteUDiskSnapshotRequest(string region, string snapshotid)
        {               
            Region = region;
            SnapshotId = snapshotid;
        }                
    }
}
