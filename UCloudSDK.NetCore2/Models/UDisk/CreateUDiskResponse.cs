namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建UDisk磁盘
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/create_udisk.html
    ///     </para>
    /// </summary>
    public partial class CreateUDiskResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UDisk实例Id                
        /// </summary>
        public string UDiskId { get; set; }

    }
}
