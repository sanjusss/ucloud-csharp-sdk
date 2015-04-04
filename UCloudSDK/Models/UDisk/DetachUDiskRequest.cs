namespace UCloudSDK.Models
{
    /// <summary>
    /// 卸载某个已经挂载在指定UHost实例上的UDisk
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/detach_udisk.html
    ///     </para>
    /// </summary>
    public partial class DetachUDiskRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DetachUDisk";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DetachUDisk
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
        /// 需要卸载的UDisk实例ID                
        /// </summary>
        public string UDiskId { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DetachUDiskRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        /// <param name="udiskid">需要卸载的UDisk实例ID</param>                    
        public DetachUDiskRequest(string region, string uhostid, string udiskid)
        {               
            Region = region;
            UHostId = uhostid;
            UDiskId = udiskid;
        }                
    }
}
