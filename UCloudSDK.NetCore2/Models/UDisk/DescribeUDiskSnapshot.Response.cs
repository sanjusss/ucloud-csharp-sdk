namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取UDisk快照
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/describe_udisk_snapshot.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDiskSnapshotResponse
    {
        /// <summary>
        /// 快照Id                
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// 快照名称                
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 快照的源UDisk的Id                
        /// </summary>
        public string UDiskId { get; set; }

        /// <summary>
        /// 快照的源UDisk的Name                
        /// </summary>
        public string UDiskName { get; set; }

        /// <summary>
        /// 创建时间                
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// 过期时间                
        /// </summary>
        public int ExpiredTime { get; set; }

        /// <summary>
        /// Year 
        ///     <para>
        ///     Month,Dynamic,Trial
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 容量单位GB                
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 快照描述                
        /// </summary>
        public string Comment { get; set; }

    }
}
