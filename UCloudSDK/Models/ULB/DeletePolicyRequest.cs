namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除内容转发策略
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/delete_policy.html
    ///     </para>
    /// </summary>
    public partial class DeletePolicyRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     DeletePolicy
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "DeletePolicy";
            }
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
        /// 内容转发策略ID                
        /// </summary>
        public string PolicyId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DeletePolicyRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="groupid">内容转发策略组ID</param>                    
        public DeletePolicyRequest(string region, string groupid)
        {               
            Region = region;
            GroupId = groupid;
        }                
    }
}
