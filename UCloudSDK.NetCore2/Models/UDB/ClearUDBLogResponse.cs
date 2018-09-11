namespace UCloudSDK.Models
{
    /// <summary>
    /// 清除udb实例的log
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/clear_udb_log.html
    ///     </para>
    /// </summary>
    public partial class ClearUDBLogResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
