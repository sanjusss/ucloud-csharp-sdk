namespace UCloudSDK.Models
{
    /// <summary>
    /// 编辑udb实例的备份黑名单
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/edit_udb_backup_blacklist.html
    ///     </para>
    /// </summary>
    public partial class EditUDBBackupBlacklistRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "EditUDBBackupBlacklist";

        /// <summary>
        /// API名称
        ///     <para>
        ///     EditUDBBackupBlacklist
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
        /// 黑名单 
        ///     <para>
        ///     规范示例abc.%;user.%;city.address;
        ///     </para>                 
        /// </summary>
        public string Blacklist { get; set; }

        /// <summary>
        /// 实例化 <see cref="EditUDBBackupBlacklistRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">DB实例Id</param>                    
        /// <param name="blacklist">黑名单</param>                    
        public EditUDBBackupBlacklistRequest(string region, string dbid, string blacklist)
        {               
            Region = region;
            DBId = dbid;
            Blacklist = blacklist;
        }                
    }
}
