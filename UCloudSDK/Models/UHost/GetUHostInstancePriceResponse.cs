using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 根据UHost实例配置，获取UHost实例的价格。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/get_uhost_instance_price.html
    ///     </para>
    /// </summary>
    public partial class GetUHostInstancePriceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     GetUHostInstancePriceResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 价格列表                
        /// </summary>
        public List<GetUHostInstancePriceSet> PriceSet { get; set; }

    }
}
