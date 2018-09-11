namespace UCloudSDK.Models
{
    /// <summary>
    /// 列表udb实例备份信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_backup.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBBackupDataSet
    {
        /// <summary>
        /// 备份id                
        /// </summary>
        public int BackupId { get; set; }

        /// <summary>
        /// 备份名称                
        /// </summary>
        public string BackupName { get; set; }

        /// <summary>
        /// 备份时间                
        /// </summary>
        public int BackupTime { get; set; }

        /// <summary>
        /// 备份文件大小                
        /// </summary>
        public int BackupSize { get; set; }

        /// <summary>
        /// 备份类型 
        ///     <para>
        ///     包括0-自动，1-手动
        ///     </para>                 
        /// </summary>
        public int BackupType { get; set; }

        /// <summary>
        /// 备份状态Backuping          // 备份中Success            // 备份成功Failed             // 备份失败Expired            // 备份过期                
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// dbid                
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 对应的db名称                
        /// </summary>
        public string DBName { get; set; }

    }
}
