namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改弹性IP的外网带宽
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/modify_eip_bandwidth.html
    ///     </para>
    /// </summary>
    public partial class ModifyEIPBandwidthRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ModifyEIPBandwidth";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ModifyEIPBandwidth
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
        /// 弹性IP的资源ID                
        /// </summary>
        public string EIPId { get; set; }

        /// <summary>
        /// 弹性IP的外网带宽 
        ///     <para>
        ///     单位为Mbps，范围 [0-800]
        ///     </para>                 
        /// </summary>
        public int Bandwidth { get; set; }

        /// <summary>
        /// 实例化 <see cref="ModifyEIPBandwidthRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="eipid">弹性IP的资源ID</param>                    
        /// <param name="bandwidth">弹性IP的外网带宽</param>                    
        public ModifyEIPBandwidthRequest(string region, string eipid, int bandwidth)
        {               
            Region = region;
            EIPId = eipid;
            Bandwidth = bandwidth;
        }                
    }
}
