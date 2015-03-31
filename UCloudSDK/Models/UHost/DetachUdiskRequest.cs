namespace UCloudSDK.Models
{
    /// <summary>
    /// 卸载某个已经挂载在指定UHost实例上的UDisk
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/detach_udisk.html
    ///     </para>
    /// </summary>
    public partial class DetachUdiskRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     DetachUdisk
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "DetachUdisk";
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
        /// 需要卸载的UDisk实例ID                
        /// </summary>
        public string UDiskId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DetachUdiskRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        /// <param name="udiskid">需要卸载的UDisk实例ID</param>                    
        public DetachUdiskRequest(string region, string uhostid, string udiskid)
        {               
            Region = region;
            UHostId = uhostid;
            UDiskId = udiskid;
        }                
    }
}
