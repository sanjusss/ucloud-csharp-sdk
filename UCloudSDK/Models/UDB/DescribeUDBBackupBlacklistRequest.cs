namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb实例的备份黑名单
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_backup_blacklist.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBBackupBlacklistRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUDBBackupBlacklist
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeUDBBackupBlacklist";
            }
        }  
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     请参见数据中心RegionList
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// DB实例Id                
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeUDBBackupBlacklistRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">DB实例Id</param>                    
        public DescribeUDBBackupBlacklistRequest(string region, string dbid)
        {               
            Region = region;
            DBId = dbid;
        }                
    }
}
