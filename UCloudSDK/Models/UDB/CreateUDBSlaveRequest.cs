namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建udb实例的slave
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/create_udb_slave.html
    ///     </para>
    /// </summary>
    public partial class CreateUDBSlaveRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateUDBSlave";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateUDBSlave
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
        /// master实例的DBId                
        /// </summary>
        public string SrcId { get; set; }

        /// <summary>
        /// 实例名称 
        ///     <para>
        ///     至少6位
        ///     </para>                 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 端口号 
        ///     <para>
        ///     mysql默认3306
        ///     </para>                 
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// 是否使用SSD 
        ///     <para>
        ///     默认为false
        ///     </para>                 
        /// </summary>
        public bool? UseSSD { get; set; }

        /// <summary>
        /// 使用的代金券id                
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// 是否锁主库 
        ///     <para>
        ///     默认为true
        ///     </para>                 
        /// </summary>
        public bool? IsLock { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateUDBSlaveRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="srcid">master实例的DBId</param>                    
        /// <param name="name">实例名称</param>                    
        public CreateUDBSlaveRequest(string region, string srcid, string name)
        {               
            Region = region;
            SrcId = srcid;
            Name = name;
        }                
    }
}
