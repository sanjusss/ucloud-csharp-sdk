namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb实例的备份黑名单
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_backup_blacklist.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBBackupBlacklistResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 黑名单                
        /// </summary>
        public string Blacklist { get; set; }

    }
}
