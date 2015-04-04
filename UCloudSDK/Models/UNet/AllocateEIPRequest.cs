namespace UCloudSDK.Models
{
    /// <summary>
    /// 根据提供信息，分配弹性IP
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/allocate_eip.html
    ///     </para>
    /// </summary>
    public partial class AllocateEIPRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "AllocateEIP";

        /// <summary>
        /// API名称
        ///     <para>
        ///     AllocateEIP
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
        ///     单位为Mbps，范围 [0-800]；共享带宽模式必须指定0M带宽，非共享带宽模式必须指定非0M带宽
        ///     </para>                 
        /// </summary>
        public int Bandwidth { get; set; }

        /// <summary>
        /// 计费模式 
        ///     <para>
        ///     枚举值为：Year，按年付费；Month，按月付费；Dynamic，按需付费(需开启权限)；Trial，试用(需开启权限)默认为按月付费
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 购买时长 
        ///     <para>
        ///     默认: 1
        ///     </para>                 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// 实例化 <see cref="AllocateEIPRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="operatorname">弹性IP的线路如下</param>                    
        /// <param name="bandwidth">弹性IP的外网带宽</param>                    
        public AllocateEIPRequest(string region, string operatorname, int bandwidth)
        {               
            Region = region;
            OperatorName = operatorname;
            Bandwidth = bandwidth;
        }                
    }
}
