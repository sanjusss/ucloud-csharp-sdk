namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建防火墙组
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/create_security_group.html
    ///     </para>
    /// </summary>
    public partial class CreateSecurityGroupResponse : UResponse
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
