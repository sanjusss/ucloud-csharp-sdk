namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建UDisk磁盘
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/create_udisk.html
    ///     </para>
    /// </summary>
    public partial class CreateUDiskRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateUDisk";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateUDisk
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }

        /// <summary>
        /// 数数据中心 
        ///     <para>
        ///      参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 磁盘大小 
        ///     <para>
        ///      单位:GB, 范围[1~1000]
        ///     </para>                 
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 实例名称                
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 使用的代金券id                
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// Year  
        ///     <para>
        ///      Month, Dynamic, Trial 默认: Dynamic
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
        /// 实例化 <see cref="CreateUDiskRequest" /> 类.
        /// </summary>
        /// <param name="region">数数据中心</param>
        /// <param name="name">硬盘名称.</param>
        /// <param name="size">磁盘大小</param>
        public CreateUDiskRequest(string region,string name, int size)
        {
            Region = region;
            Name = name;
            Size = size;
        }
    }
}
