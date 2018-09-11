namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb实例价格信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_instance_price.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBInstancePriceDataSet
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
        ///     <para>
        ///     单位分
        ///     </para>                 
        /// </summary>
        public float Price { get; set; }

    }
}
