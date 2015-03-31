namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改指定UHost实例的资源配置，如CPU核心数，内存容量大小，磁盘空间大小等。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/resize_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class ResizeUHostInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ResizeUHostInstanceResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

    }
}
