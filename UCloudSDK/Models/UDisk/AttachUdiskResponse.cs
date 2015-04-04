namespace UCloudSDK.Models
{
    /// <summary>
    /// 将一个可用的UDisk挂载到某台主机上，当UDisk挂载成功后，还需要在主机内部进行文件系统操作
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/attach_udisk.html
    ///     </para>
    /// </summary>
    public partial class AttachUDiskResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     AttachUdiskResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 挂载的UHost实例ID                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// 挂载的UDisk实例ID                
        /// </summary>
        public string UDiskId { get; set; }

    }
}
