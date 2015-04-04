namespace UCloudSDK.Models
{
    /// <summary>
    /// 将一个可用的UDisk挂载到某台主机上，当UDisk挂载成功后，还需要在主机内部进行文件系统操作
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/attach_udisk.html
    ///     </para>
    /// </summary>
    public partial class AttachUDiskRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "AttachUDisk";

        /// <summary>
        /// API名称
        ///     <para>
        ///     AttachUDisk
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        } 
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///      参见 数据中心列表
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
        /// 项目编号                
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例化 <see cref="AttachUDiskRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        /// <param name="udiskid">需要挂载的UDisk实例ID</param>                    
        public AttachUDiskRequest(string region, string uhostid, string udiskid)
        {               
            Region = region;
            UHostId = uhostid;
            UDiskId = udiskid;
        }                
    }
}
