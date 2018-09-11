namespace UCloudSDK.Models
{
    /// <summary>
    /// 从快照创建UDisk克隆
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/clone_udisk_snapshot.html
    ///     </para>
    /// </summary>
    public partial class CloneUDiskSnapshotRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CloneUDiskSnapshot";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CloneUDiskSnapshot
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
        /// 实例名称                
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 克隆父Snapshot的Id                
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// 磁盘大小 
        ///     <para>
        ///      单位:GB, 范围[1~1000]
        ///     </para>                 
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 使用的代金券id                
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// Disk注释                
        /// </summary>
        public string Comment { get; set; }

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
        /// 实例化 <see cref="CloneUDiskSnapshotRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="sourceid">克隆父Snapshot的Id</param>                    
        /// <param name="size">磁盘大小</param>                    
        public CloneUDiskSnapshotRequest(string region, string sourceid, int size)
        {               
            Region = region;
            SourceId = sourceid;
            Size = size;
        }                
    }
}
