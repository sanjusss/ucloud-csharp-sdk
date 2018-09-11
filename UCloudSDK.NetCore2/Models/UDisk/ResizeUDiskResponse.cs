namespace UCloudSDK.Models
{
    /// <summary>
    /// 调整UDisk容量
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/resize_udisk.html
    ///     </para>
    /// </summary>
    public partial class ResizeUDiskResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
