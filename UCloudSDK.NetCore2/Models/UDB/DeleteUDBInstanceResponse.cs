namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/delete_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class DeleteUDBInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
