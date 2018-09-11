namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建内容转发策略
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/create_policy.html
    ///     </para>
    /// </summary>
    public partial class CreatePolicyRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreatePolicy";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreatePolicy
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
        /// 内容转发策略组ID                
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 内容转发匹配字段                
        /// </summary>
        public string Match { get; set; }

        /// <summary>
        /// 需要添加内容转发策略的负载均衡实例ID                
        /// </summary>
        public string ULBId { get; set; }

        /// <summary>
        /// 需要添加内容转发策略的VServer实例ID                
        /// </summary>
        public string VServerId { get; set; }

        /// <summary>
        /// 内容转发策略应用的后端资源实例的ID                
        /// </summary>
        public NList BackendId { get; set; }

        /// <summary>
        /// 内容转发匹配字段的类型 
        ///     <para>
        ///     当前仅支持按域名转发。枚举值：Domain
        ///     </para>                 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreatePolicyRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="groupid">内容转发策略组ID</param>                    
        /// <param name="match">内容转发匹配字段</param>                    
        /// <param name="ulbid">需要添加内容转发策略的负载均衡实例ID</param>                    
        /// <param name="vserverid">需要添加内容转发策略的VServer实例ID</param>                    
        /// <param name="backendid">内容转发策略应用的后端资源实例的ID</param>                    
        public CreatePolicyRequest(string region, string groupid, string match, string ulbid, string vserverid, NList backendid)
        {               
            Region = region;
            GroupId = groupid;
            Match = match;
            ULBId = ulbid;
            VServerId = vserverid;
            BackendId = backendid;
        }                
    }
}
