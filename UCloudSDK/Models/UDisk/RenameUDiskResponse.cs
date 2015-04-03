namespace UCloudSDK.Models
{
    /// <summary>
    /// 重命名UDisk
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/rename_udisk.html
    ///     </para>
    /// </summary>
    public partial class RenameUDiskResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
