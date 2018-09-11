namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建udb实例（包括mysql、mongodb实例和从备份恢复实例）
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/create_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class CreateUDBInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateUDBInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateUDBInstance
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
        /// DB类型id 
        ///     <para>
        ///     mysql/mongodb按版本细分各有一个id1：mysql-5.5，2：mysql-5.1，3：percona-5.54：mongodb-2.4，5：mongodb-2.6，6：mysql-5.6，7：percona-5.6
        ///     </para>                 
        /// </summary>
        public string DBTypeId { get; set; }

        /// <summary>
        /// Year 
        ///     <para>
        ///      Month， Dynamic，Trial，默认: Dynamic
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 使用的代金券id                
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// 购买时长 
        ///     <para>
        ///     默认值1
        ///     </para>                 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// 实例名称 
        ///     <para>
        ///     至少6位
        ///     </para>                 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 管理员帐户名 
        ///     <para>
        ///     默认root
        ///     </para>                 
        /// </summary>
        public string AdminUser { get; set; }

        /// <summary>
        /// 管理员密码                
        /// </summary>
        public string AdminPassword { get; set; }

        /// <summary>
        /// 端口号 
        ///     <para>
        ///     mysql默认3306，mongodb默认27017
        ///     </para>                 
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// DB实例使用的配置参数组id                
        /// </summary>
        public int ParamGroupId { get; set; }

        /// <summary>
        /// 内存限制(MB) 
        ///     <para>
        ///     目前支持以下几档600M/1500M/3000M/6000M/15000M/30000M
        ///     </para>                 
        /// </summary>
        public int MemoryLimit { get; set; }

        /// <summary>
        /// 磁盘空间(GB) 
        ///     <para>
        ///      暂时支持20G - 500G
        ///     </para>                 
        /// </summary>
        public int DiskSpace { get; set; }

        /// <summary>
        /// 备份策略 
        ///     <para>
        ///     每周备份数量，默认7次
        ///     </para>                 
        /// </summary>
        public int? BackupCount { get; set; }

        /// <summary>
        /// 备份策略 
        ///     <para>
        ///     备份开始时间，单位小时计，默认3点
        ///     </para>                 
        /// </summary>
        public int? BackupTime { get; set; }

        /// <summary>
        /// 备份策略 
        ///     <para>
        ///     备份时间间隔，单位小时计，默认24小时
        ///     </para>                 
        /// </summary>
        public int? BackupDuration { get; set; }

        /// <summary>
        /// 备份id 
        ///     <para>
        ///     如果指定，则表明从备份恢复实例
        ///     </para>                 
        /// </summary>
        public int? BackupId { get; set; }

        /// <summary>
        /// 是否使用SSD 
        ///     <para>
        ///     默认为false
        ///     </para>                 
        /// </summary>
        public bool? UseSSD { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateUDBInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbtypeid">DB类型id</param>                    
        /// <param name="name">实例名称</param>                    
        /// <param name="adminpassword">管理员密码</param>                    
        /// <param name="port">端口号</param>                    
        /// <param name="paramgroupid">DB实例使用的配置参数组id</param>                    
        /// <param name="memorylimit">内存限制(MB)</param>                    
        /// <param name="diskspace">磁盘空间(GB)</param>                    
        public CreateUDBInstanceRequest(string region, string dbtypeid, string name, string adminpassword, int port, int paramgroupid, int memorylimit, int diskspace)
        {               
            Region = region;
            DBTypeId = dbtypeid;
            Name = name;
            AdminPassword = adminpassword;
            Port = port;
            ParamGroupId = paramgroupid;
            MemoryLimit = memorylimit;
            DiskSpace = diskspace;
        }                
    }
}
