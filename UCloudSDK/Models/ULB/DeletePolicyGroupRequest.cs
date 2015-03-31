namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除内容转发策略组
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/delete_policy_group.html
    ///     </para>
    /// </summary>
    public partial class DeletePolicyGroupRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     DeletePolicyGroup
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "DeletePolicyGroup";
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
        /// 实例化 <see cref="DeletePolicyGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="groupid">内容转发策略组ID</param>                    
        public DeletePolicyGroupRequest(string region, string groupid)
        {               
            Region = region;
            GroupId = groupid;
        }                
    }
}
