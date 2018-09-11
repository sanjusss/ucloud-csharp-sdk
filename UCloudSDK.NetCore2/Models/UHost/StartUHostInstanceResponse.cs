namespace UCloudSDK.Models
{
    /// <summary>
    /// 启动处于关闭状态的UHost实例，需要指定数据中心及UHostID两个参数的值。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/start_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class StartUHostInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     StartUHostInstanceResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

    }
}
