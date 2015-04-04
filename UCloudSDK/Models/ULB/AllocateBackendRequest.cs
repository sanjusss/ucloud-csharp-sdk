namespace UCloudSDK.Models
{
    /// <summary>
    /// 添加ULB后端资源实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/allocate_backend.html
    ///     </para>
    /// </summary>
    public partial class AllocateBackendRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "AllocateBackend";

        /// <summary>
        /// API名称
        ///     <para>
        ///     AllocateBackend
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
        /// 负载均衡实例的ID                
        /// </summary>
        public string ULBId { get; set; }

        /// <summary>
        /// VServer实例的ID                
        /// </summary>
        public string VServerId { get; set; }

        /// <summary>
        /// 所添加的后端资源的类型 
        ///     <para>
        ///     如UHost
        ///     </para>                 
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// 所添加的后端资源的资源ID                
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// 所添加的后端资源服务端口 
        ///     <para>
        ///     取值范围[1-65535]，默认80
        ///     </para>                 
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// 后端实例状态开关 
        ///     <para>
        ///     枚举值：1：启动；0：禁用默认为启用
        ///     </para>                 
        /// </summary>
        public int? Enabled { get; set; }

        /// <summary>
        /// 实例化 <see cref="AllocateBackendRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="ulbid">负载均衡实例的ID</param>                    
        /// <param name="vserverid">VServer实例的ID</param>                    
        /// <param name="resourcetype">所添加的后端资源的类型</param>                    
        /// <param name="resourceid">所添加的后端资源的资源ID</param>                    
        public AllocateBackendRequest(string region, string ulbid, string vserverid, string resourcetype, string resourceid)
        {               
            Region = region;
            ULBId = ulbid;
            VServerId = vserverid;
            ResourceType = resourcetype;
            ResourceId = resourceid;
        }                
    }
}
