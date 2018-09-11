namespace UCloudSDK.Models
{
    /// <summary>
    /// 根据UHost实例配置，获取UHost实例的价格。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/get_uhost_instance_price.html
    ///     </para>
    /// </summary>
    public partial class GetUHostInstancePriceSet
    {
        /// <summary>
        /// Year 
        ///     <para>
        ///     Month，Dynamic
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 价格 
        ///     <para>
        ///     单位: 元，保留小数点后两位有效数字
        ///     </para>                 
        /// </summary>
        public float Price { get; set; }

    }
}
