namespace UCloudSDK.Models
{
    /// <summary>
    /// 从UDisk创建UDisk克隆
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/clone_udisk.html
    ///     </para>
    /// </summary>
    public partial class CloneUDiskResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 创建UDisk Id                
        /// </summary>
        public string UDiskId { get; set; }

    }
}
