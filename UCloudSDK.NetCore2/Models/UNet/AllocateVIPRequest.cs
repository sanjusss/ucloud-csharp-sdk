namespace UCloudSDK.Models
{
    /// <summary>
    /// 根据提供信息，分配内网VIP(Virtual IP，多用于高可用程序作为漂移IP。)
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/allocate_vip.html
    ///     </para>
    /// </summary>
    public partial class AllocateVIPRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "AllocateVIP";

        /// <summary>
        /// API名称
        ///     <para>
        ///     AllocateVIP
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
        /// 申请数量 
        ///     <para>
        ///     默认: 1
        ///     </para>                 
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// 实例化 <see cref="AllocateVIPRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public AllocateVIPRequest(string region)
        {               
            Region = region;
        }                
    }
}
