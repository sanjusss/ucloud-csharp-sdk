namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除防火墙
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/delete_security_group.html
    ///     </para>
    /// </summary>
    public partial class DeleteSecurityGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreateSecurityGroupResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
