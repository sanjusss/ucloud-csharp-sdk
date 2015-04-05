namespace UCloudSDK.Models
{
    /// <summary>
    /// 备份udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/backup_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class BackupUDBInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "BackupUDBInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     BackupUDBInstance
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
        /// DB实例Id                
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 备份名称                
        /// </summary>
        public string BackupName { get; set; }

        /// <summary>
        /// 是否使用黑名单备份 
        ///     <para>
        ///     默认false
        ///     </para>                 
        /// </summary>
        public bool? UseBlacklist { get; set; }

        /// <summary>
        /// 实例化 <see cref="BackupUDBInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">DB实例Id</param>                    
        /// <param name="backupname">备份名称</param>                    
        public BackupUDBInstanceRequest(string region, string dbid, string backupname)
        {               
            Region = region;
            DBId = dbid;
            BackupName = backupname;
        }                
    }
}
