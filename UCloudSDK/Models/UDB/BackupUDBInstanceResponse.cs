namespace UCloudSDK.Models
{
    /// <summary>
    /// 备份udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/backup_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class BackupUDBInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
