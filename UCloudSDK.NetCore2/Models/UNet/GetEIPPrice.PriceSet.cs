namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取弹性IP价格
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/get_eip_price.html
    ///     </para>
    /// </summary>
    public partial class GetEIPPriceSet
    {
        /// <summary>
        /// 弹性IP计费类型                
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 弹性IP价格                
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 资源有效期 
        ///     <para>
        ///     以Unix Timestamp表示
        ///     </para>                 
        /// </summary>
        public int PurchaseValue { get; set; }

    }
}
