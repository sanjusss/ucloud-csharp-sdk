namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udisk升级价格信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/describe_udisk_upgrade_price.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDiskUpgradePriceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUDiskUpgradePrice";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUDiskUpgradePrice
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
        /// 购买UDisk大小 
        ///     <para>
        ///     单位:GB,范围[1~1000]
        ///     </para>                 
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 升级目标UDisk ID                
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeUDiskUpgradePriceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>             
        /// <param name="sourceid">升级目标UDisk ID</param>                    
        /// <param name="size">购买UDisk大小</param>                           
        public DescribeUDiskUpgradePriceRequest(string region, string sourceid, int size)
        {               
            Region = region;
            Size = size;
            SourceId = sourceid;
        }                
    }
}
