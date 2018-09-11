namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除UDisk
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/delete_udisk.html
    ///     </para>
    /// </summary>
    public partial class DeleteUDiskResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
