namespace UCloudSDK.Models
{
    /// <summary>
    /// 从库提升为独立库
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/promote_udb_slave.html
    ///     </para>
    /// </summary>
    public partial class PromoteUDBSlaveRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "PromoteUDBSlave";

        /// <summary>
        /// API名称
        ///     <para>
        ///     PromoteUDBSlave
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
        /// 实例的Id                
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 是否强制(如果从库落后可能会禁止提升) 
        ///     <para>
        ///     默认false如果落后情况下，强制提升丢失数据
        ///     </para>                 
        /// </summary>
        public bool? IsForce { get; set; }

        /// <summary>
        /// 实例化 <see cref="PromoteUDBSlaveRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">实例的Id</param>                    
        public PromoteUDBSlaveRequest(string region, string dbid)
        {               
            Region = region;
            DBId = dbid;
        }                
    }
}
