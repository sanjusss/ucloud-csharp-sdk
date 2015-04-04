namespace UCloudSDK.Models
{
    /// <summary>
    /// 释放VIP资源
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/release_vip.html
    ///     </para>
    /// </summary>
    public partial class ReleaseVIPRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ReleaseVIP";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ReleaseVIP
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
        /// 内网VIP的IP地址                
        /// </summary>
        public string VIP { get; set; }

        /// <summary>
        /// 实例化 <see cref="ReleaseVIPRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="vip">内网VIP的IP地址</param>                    
        public ReleaseVIPRequest(string region, string vip)
        {               
            Region = region;
            VIP = vip;
        }                
    }
}
