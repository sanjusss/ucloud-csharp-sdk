using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取弹性IP价格
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/get_eip_price.html
    ///     </para>
    /// </summary>
    public partial class GetEIPPriceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     GetEIPPriceResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 弹性IP价格详情                
        /// </summary>
        public List<GetEIPPriceSet> PriceSet { get; set; }

    }
}
