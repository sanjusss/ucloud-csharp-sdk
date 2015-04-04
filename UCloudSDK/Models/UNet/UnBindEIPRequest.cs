namespace UCloudSDK.Models
{
    /// <summary>
    /// 将弹性IP从资源上解绑
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/unbind_eip.html
    ///     </para>
    /// </summary>
    public partial class UnBindEIPRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UnBindEIP";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UnBindEIP
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
        /// 弹性IP请求解绑的资源类型 
        ///     <para>
        ///     枚举值为：uhost：云主机；vrouter：虚拟路由器；ulb，负载均衡器
        ///     </para>                 
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// 弹性IP请求解绑的资源ID                
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// 实例化 <see cref="UnBindEIPRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="eipid">弹性IP的资源Id</param>                    
        /// <param name="resourcetype">弹性IP请求解绑的资源类型</param>                    
        /// <param name="resourceid">弹性IP请求解绑的资源ID</param>                    
        public UnBindEIPRequest(string region, string eipid, string resourcetype, string resourceid)
        {               
            Region = region;
            EIPId = eipid;
            ResourceType = resourcetype;
            ResourceId = resourceid;
        }                
    }
}
