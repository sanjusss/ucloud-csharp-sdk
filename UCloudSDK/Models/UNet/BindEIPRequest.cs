namespace UCloudSDK.Models
{
    /// <summary>
    /// 将弹性IP绑定到资源上
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/bind_eip.html
    ///     </para>
    /// </summary>
    public partial class BindEIPRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "BindEIP";

        /// <summary>
        /// API名称
        ///     <para>
        ///     BindEIP
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
        /// 弹性IP的资源Id                
        /// </summary>
        public string EIPId { get; set; }

        /// <summary>
        /// 弹性IP请求绑定的资源类型 
        ///     <para>
        ///     枚举值为：uhost：云主机；vrouter：虚拟路由器；ulb，负载均衡器
        ///     </para>                 
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// 弹性IP请求绑定的资源ID                
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// 实例化 <see cref="BindEIPRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="eipid">弹性IP的资源Id</param>                    
        /// <param name="resourcetype">弹性IP请求绑定的资源类型</param>                    
        /// <param name="resourceid">弹性IP请求绑定的资源ID</param>                    
        public BindEIPRequest(string region, string eipid, string resourcetype, string resourceid)
        {               
            Region = region;
            EIPId = eipid;
            ResourceType = resourcetype;
            ResourceId = resourceid;
        }                
    }
}
