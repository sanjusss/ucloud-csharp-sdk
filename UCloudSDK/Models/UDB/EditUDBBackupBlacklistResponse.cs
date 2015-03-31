namespace UCloudSDK.Models
{
    /// <summary>
    /// 编辑udb实例的备份黑名单
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/edit_udb_backup_blacklist.html
    ///     </para>
    /// </summary>
    public partial class EditUDBBackupBlacklistResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
