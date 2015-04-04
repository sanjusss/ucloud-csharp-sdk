namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改ULB后端资源实例(主机池)属性
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/update_backend_attribute.html
    ///     </para>
    /// </summary>
    public partial class UpdateBackendAttributeRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UpdateBackendAttribute";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UpdateBackendAttribute
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
        /// 负载均衡资源ID                
        /// </summary>
        public string ULBId { get; set; }

        /// <summary>
        /// 后端资源实例的ID(ULB后端ID 
        ///     <para>
        ///     非资源自身ID)
        ///     </para>                 
        /// </summary>
        public string BackendId { get; set; }

        /// <summary>
        /// 后端资源服务端口 
        ///     <para>
        ///     取值范围[1-65535]
        ///     </para>                 
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// 后端实例状态开关 
        ///     <para>
        ///     枚举值：1：启动；0：禁用若无此字段，则不做修改
        ///     </para>                 
        /// </summary>
        public int? Enabled { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdateBackendAttributeRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="ulbid">负载均衡资源ID</param>                    
        /// <param name="backendid">后端资源实例的ID(ULB后端ID</param>                    
        public UpdateBackendAttributeRequest(string region, string ulbid, string backendid)
        {               
            Region = region;
            ULBId = ulbid;
            BackendId = backendid;
        }                
    }
}
