namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除udb实例备份
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/delete_udb_backup.html
    ///     </para>
    /// </summary>
    public partial class DeleteUDBBackupResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
