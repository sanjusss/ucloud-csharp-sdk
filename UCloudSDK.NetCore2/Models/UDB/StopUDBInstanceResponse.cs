namespace UCloudSDK.Models
{
    /// <summary>
    /// 关闭udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/stop_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class StopUDBInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
