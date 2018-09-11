namespace UCloudSDK.Models
{
    /// <summary>
    /// 调整UDisk容量
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/resize_udisk.html
    ///     </para>
    /// </summary>
    public partial class ResizeUDiskRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ResizeUDisk";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ResizeUDisk
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
        /// UDisk Id                
        /// </summary>
        public string UDiskId { get; set; }

        /// <summary>
        /// 调整后大小 
        ///     <para>
        ///      单位:GB, 范围[1~1000],只能增大
        ///     </para>                 
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 使用的代金券id                
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例化 <see cref="ResizeUDiskRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="udiskid">UDisk Id</param>                    
        /// <param name="size">调整后大小</param>                    
        public ResizeUDiskRequest(string region, string udiskid, int size)
        {               
            Region = region;
            UDiskId = udiskid;
            Size = size;
        }                
    }
}
