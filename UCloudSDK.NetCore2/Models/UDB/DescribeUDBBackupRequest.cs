namespace UCloudSDK.Models
{
    /// <summary>
    /// 列表udb实例备份信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_backup.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBBackupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUDBBackup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUDBBackup
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
        /// 分页显示的起始偏移 
        ///     <para>
        ///     列表操作则指定
        ///     </para>                 
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// 分页显示的条目数 
        ///     <para>
        ///     列表操作则指定
        ///     </para>                 
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// DB实例Id 
        ///     <para>
        ///     如果指定，则只获取该db的备份信息
        ///     </para>                 
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 备份类型 
        ///     <para>
        ///     包括0-自动，1-手动
        ///     </para>                 
        /// </summary>
        public int? BackupType { get; set; }

        /// <summary>
        /// 过滤条件 
        ///     <para>
        ///     起始时间(时间戳)
        ///     </para>                 
        /// </summary>
        public int? BeginTime { get; set; }

        /// <summary>
        /// 过滤条件 
        ///     <para>
        ///     结束时间(时间戳)
        ///     </para>                 
        /// </summary>
        public int? EndTime { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeUDBBackupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="offset">分页显示的起始偏移</param>                    
        /// <param name="limit">分页显示的条目数</param>                    
        public DescribeUDBBackupRequest(string region, int offset, int limit)
        {               
            Region = region;
            Offset = offset;
            Limit = limit;
        }                
    }
}
