namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除udb实例备份
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/delete_udb_backup.html
    ///     </para>
    /// </summary>
    public partial class DeleteUDBBackupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DeleteUDBBackup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DeleteUDBBackup
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        } 
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     请参见数据中心RegionList
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public int? ProjectId { get; set; }

        /// <summary>
        /// 备份id 
        ///     <para>
        ///     可通过DescribeUDBBackup获得
        ///     </para>                 
        /// </summary>
        public int BackupId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DeleteUDBBackupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="backupid">备份id</param>                    
        public DeleteUDBBackupRequest(string region, int backupid)
        {               
            Region = region;
            BackupId = backupid;
        }                
    }
}
