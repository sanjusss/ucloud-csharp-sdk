namespace UCloudSDK.Models
{
    /// <summary>
    /// 释放EIP资源
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/release_eip.html
    ///     </para>
    /// </summary>
    public partial class ReleaseEIPRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ReleaseEIP";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ReleaseEIP
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
        /// 实例化 <see cref="ReleaseEIPRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="eipid">弹性IP的资源ID</param>                    
        public ReleaseEIPRequest(string region, string eipid)
        {               
            Region = region;
            EIPId = eipid;
        }                
    }
}
