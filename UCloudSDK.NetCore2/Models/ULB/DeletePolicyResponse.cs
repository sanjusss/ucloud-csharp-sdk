namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除内容转发策略
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/delete_policy.html
    ///     </para>
    /// </summary>
    public partial class DeletePolicyResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreatePolicyResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
