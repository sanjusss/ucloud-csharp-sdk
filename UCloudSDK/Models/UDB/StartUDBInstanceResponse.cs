namespace UCloudSDK.Models
{
    /// <summary>
    /// 启动udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/start_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class StartUDBInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
