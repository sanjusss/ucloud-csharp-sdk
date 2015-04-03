namespace UCloudSDK.Models
{
    /// <summary>
    /// 卸载某个已经挂载在指定UHost实例上的UDisk
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/detach_udisk.html
    ///     </para>
    /// </summary>
    public partial class DetachUDiskResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DetachUdiskResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 卸载的UHost实例ID                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// 卸载的UDisk实例ID                
        /// </summary>
        public string UDiskId { get; set; }

    }
}
