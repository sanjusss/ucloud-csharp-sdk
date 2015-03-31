namespace UCloudSDK.Models
{
    /// <summary>
    /// 重启udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/restart_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class RestartUDBInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
