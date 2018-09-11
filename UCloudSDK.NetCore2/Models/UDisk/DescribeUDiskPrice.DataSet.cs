namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udisk实例价格信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/describe_udisk_price.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDiskPriceDataSet
    {
        /// <summary>
        /// Year 
        ///     <para>
        ///      Month， Dynamic，Trial
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 价格                
        /// </summary>
        public float Price { get; set; }

    }
}
