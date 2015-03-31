namespace UCloudSDK.Models
{
    /// <summary>
    /// 指停止处于运行状态的UHost实例，需指定数据中心及UhostID。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/stop_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class StopUHostInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     StopUHostInstanceResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

    }
}
