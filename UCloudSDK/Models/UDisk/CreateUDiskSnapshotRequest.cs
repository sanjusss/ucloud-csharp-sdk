namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建snapshot快照
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/create_udisk_snapshot.html
    ///     </para>
    /// </summary>
    public partial class CreateUDiskSnapshotRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateUDiskSnapshot";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateUDiskSnapshot
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
        ///      参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 快照的UDisk的Id                
        /// </summary>
        public int UDiskId { get; set; }

        /// <summary>
        /// 快照名称                
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Year  
        ///     <para>
        ///      Month, Dynamic 默认: Dynamic
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 购买时长 默认 
        ///     <para>
        ///      1
        ///     </para>                 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 快照描述                
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateUDiskSnapshotRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="udiskid">快照的UDisk的Id</param>                    
        public CreateUDiskSnapshotRequest(string region, int udiskid)
        {               
            Region = region;
            UDiskId = udiskid;
        }                
    }
}
