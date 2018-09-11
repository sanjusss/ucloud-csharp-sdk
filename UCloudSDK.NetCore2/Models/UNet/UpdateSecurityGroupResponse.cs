namespace UCloudSDK.Models
{
    /// <summary>
    /// 更新防火墙规则
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/update_security_group.html
    ///     </para>
    /// </summary>
    public partial class UpdateSecurityGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     UpdateSecurityGroupResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
