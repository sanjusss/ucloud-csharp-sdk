namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udisk实例价格信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/describe_udisk_price.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDiskPriceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUDiskPrice";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUDiskPrice
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
        /// Year 
        ///     <para>
        ///      Month， Dynamic，Trial，默认: Dynamic如果不指定，则一次性获取三种计费
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 购买UDisk的时长 
        ///     <para>
        ///     默认值为1
        ///     </para>                 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeUDiskPriceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="size">购买UDisk大小</param>                    
        public DescribeUDiskPriceRequest(string region, int size)
        {               
            Region = region;
            Size = size;
        }                
    }
}
