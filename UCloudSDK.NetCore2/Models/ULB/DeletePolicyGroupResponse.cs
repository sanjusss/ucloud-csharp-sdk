namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除内容转发策略组
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/delete_policy_group.html
    ///     </para>
    /// </summary>
    public partial class DeletePolicyGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DeletePolicyGroupResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
