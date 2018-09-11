namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udisk升级价格信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/describe_udisk_upgrade_price.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDiskUpgradePriceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 价格                
        /// </summary>
        public float Price { get; set; }

    }
}
