namespace UCloudSDK.Models
{
    /// <summary>
    /// 重置UHost实例的管理员密码。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/reset_uhost_instance_password.html
    ///     </para>
    /// </summary>
    public partial class ResetUHostInstancePasswordResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ResetUHostInstancePasswordResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

    }
}
