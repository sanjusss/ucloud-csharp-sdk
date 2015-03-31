namespace UCloudSDK.Models
{
    /// <summary>
    /// 重新安装指定UHost实例的操作系统
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/reinstall_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class ReinstallUHostInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ReinstallUHostInstanceResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例资源ID                
        /// </summary>
        public string UhostId { get; set; }

    }
}
