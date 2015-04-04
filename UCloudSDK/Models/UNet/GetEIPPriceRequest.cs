namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取弹性IP价格
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/get_eip_price.html
    ///     </para>
    /// </summary>
    public partial class GetEIPPriceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "GetEIPPrice";

        /// <summary>
        /// API名称
        ///     <para>
        ///     GetEIPPrice
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
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 弹性IP的线路如下 
        ///     <para>
        ///     电信: Telecom联通: Unicom国际: InternationalBGP: Bgp双线: Duplet各数据中心允许的线路参数如下：cn-east-01: Telecom, Unicom, Dupletcn-south-01: Telecom, Unicom, Dupletcn-north-01: Bgpcn-north-02: Bgpcn-north-03: Bgphk-01: Internationalus-west-01: International
        ///     </para>                 
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// 弹性IP的外网带宽 
        ///     <para>
        ///     单位为Mbps，范围 [0-800]；
        ///     </para>                 
        /// </summary>
        public int Bandwidth { get; set; }

        /// <summary>
        /// 计费模式 
        ///     <para>
        ///     枚举值为：Year，按年付费；Month，按月付费；Dynamic，按需付费(需开启权限)；默认为获取三种价格
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 实例化 <see cref="GetEIPPriceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="operatorname">弹性IP的线路如下</param>                    
        /// <param name="bandwidth">弹性IP的外网带宽</param>                    
        public GetEIPPriceRequest(string region, string operatorname, int bandwidth)
        {               
            Region = region;
            OperatorName = operatorname;
            Bandwidth = bandwidth;
        }                
    }
}
