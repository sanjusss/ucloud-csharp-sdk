namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改内容转发策略组配置信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/update_policy_group_attribute.html
    ///     </para>
    /// </summary>
    public partial class UpdatePolicyGroupAttributeRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UpdatePolicyGroupAttribute";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UpdatePolicyGroupAttribute
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
        /// 修改策略转发组名称                
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdatePolicyGroupAttributeRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="groupid">内容转发策略组ID</param>                    
        public UpdatePolicyGroupAttributeRequest(string region, string groupid)
        {               
            Region = region;
            GroupId = groupid;
        }                
    }
}
