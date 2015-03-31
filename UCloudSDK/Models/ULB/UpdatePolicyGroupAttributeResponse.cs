namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改内容转发策略组配置信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/update_policy_group_attribute.html
    ///     </para>
    /// </summary>
    public partial class UpdatePolicyGroupAttributeResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     UpdatePolicyGroupAttributeResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
