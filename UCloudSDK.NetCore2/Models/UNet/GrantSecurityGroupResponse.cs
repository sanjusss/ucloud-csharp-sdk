namespace UCloudSDK.Models
{
    /// <summary>
    /// 将防火墙应用到资源上
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/grant_security_group.html
    ///     </para>
    /// </summary>
    public partial class GrantSecurityGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     GrantSecurityGroupResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
