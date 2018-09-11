namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建mongodb的副本节点（包括仲裁）
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/create_udb_replication_instance.html
    ///     </para>
    /// </summary>
    public partial class CreateUDBReplicationInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateUDBReplicationInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateUDBReplicationInstance
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
        /// primary节点的DBId                
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
        ///     默认27017
        ///     </para>                 
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// 是否是仲裁节点 
        ///     <para>
        ///     默认false，仲裁节点按最小机型创建
        ///     </para>                 
        /// </summary>
        public bool? IsArbiter { get; set; }

        /// <summary>
        /// 使用的代金券id                
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateUDBReplicationInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="srcid">primary节点的DBId</param>                    
        /// <param name="name">实例名称</param>                    
        public CreateUDBReplicationInstanceRequest(string region, string srcid, string name)
        {               
            Region = region;
            SrcId = srcid;
            Name = name;
        }                
    }
}
