namespace UCloudSDK.Models
{
    /// <summary>
    /// 重新启动UHost实例，需要指定数据中心及UHostID两个参数的值。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/reboot_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class RebootUHostInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     RebootUHostInstanceResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

    }
}
