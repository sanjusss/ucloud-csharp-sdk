namespace UCloudSDK.Models
{
    /// <summary>
    /// 将一个可用的UDisk挂载到某台主机上，当UDisk挂载成功后，还需要在主机内部进行文件系统操作。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/attach_udisk.html
    ///     </para>
    /// </summary>
    public partial class AttachUdiskRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     AttachUdisk
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "AttachUdisk";
            }
        }  
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// 需要挂载的UDisk实例ID                
        /// </summary>
        public string UDiskId { get; set; }

        /// <summary>
        /// 实例化 <see cref="AttachUdiskRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        /// <param name="udiskid">需要挂载的UDisk实例ID</param>                    
        public AttachUdiskRequest(string region, string uhostid, string udiskid)
        {               
            Region = region;
            UHostId = uhostid;
            UDiskId = udiskid;
        }                
    }
}
