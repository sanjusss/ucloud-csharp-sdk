namespace UCloudSDK.Models
{
    /// <summary>
    /// 从库提升为独立库
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/promote_udb_slave.html
    ///     </para>
    /// </summary>
    public partial class PromoteUDBSlaveResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
