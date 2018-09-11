namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建内容转发策略组
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/create_policy_group.html
    ///     </para>
    /// </summary>
    public partial class CreatePolicyGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreatePolicyGroupResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 内容转发策略组的Id                
        /// </summary>
        public string GroupId { get; set; }

    }
}
