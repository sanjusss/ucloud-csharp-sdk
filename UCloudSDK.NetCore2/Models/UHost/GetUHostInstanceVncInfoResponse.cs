namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取指定UHost实例的管理VNC配置详细信息。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/get_uhost_instance_vnc_info.html
    ///     </para>
    /// </summary>
    public partial class GetUHostInstanceVncInfoResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     GetUHostInstanceVncInfoResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

        /// <summary>
        /// Vnc登录IP                
        /// </summary>
        public string VncIP { get; set; }

        /// <summary>
        /// Vnc登录端口                
        /// </summary>
        public int VncPort { get; set; }

        /// <summary>
        /// Vnc 登录密码                
        /// </summary>
        public string VncPassword { get; set; }

    }
}
