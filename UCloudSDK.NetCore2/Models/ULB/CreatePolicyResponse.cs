namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建内容转发策略
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/create_policy.html
    ///     </para>
    /// </summary>
    public partial class CreatePolicyResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreatePolicyResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 内容转发策略ID                
        /// </summary>
        public string PolicyId { get; set; }

    }
}
