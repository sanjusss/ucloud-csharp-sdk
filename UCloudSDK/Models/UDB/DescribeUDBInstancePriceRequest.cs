namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb实例价格信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_instance_price.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBInstancePriceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUDBInstancePrice";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUDBInstancePrice
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
        /// 购买DB实例数量                
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Year 
        ///     <para>
        ///      Month， Dynamic，Trial，默认: Dynamic如果不指定，则一次性获取三种计费
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 购买DB的时长 
        ///     <para>
        ///     默认值为1
        ///     </para>                 
        /// </summary>
        public int? Quantity { get; set; }

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
        /// 是否使用SSD 
        ///     <para>
        ///     默认为false
        ///     </para>                 
        /// </summary>
        public bool? UseSSD { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeUDBInstancePriceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="count">购买DB实例数量</param>                    
        /// <param name="memorylimit">内存限制(MB)</param>                    
        /// <param name="diskspace">磁盘空间(GB)</param>                    
        public DescribeUDBInstancePriceRequest(string region, int count, int memorylimit, int diskspace)
        {               
            Region = region;
            Count = count;
            MemoryLimit = memorylimit;
            DiskSpace = diskspace;
        }                
    }
}
