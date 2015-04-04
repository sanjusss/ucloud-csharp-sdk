namespace UCloudSDK.Models
{
    /// <summary>
    /// 重命名UDisk
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/rename_udisk.html
    ///     </para>
    /// </summary>
    public partial class RenameUDiskRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "RenameUDisk";

        /// <summary>
        /// API名称
        ///     <para>
        ///     RenameUDisk
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
        /// 重命名的UDisk的Id                
        /// </summary>
        public string UDiskId { get; set; }

        /// <summary>
        /// 重命名UDisk的name                
        /// </summary>
        public string UDiskName { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例化 <see cref="RenameUDiskRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="udiskid">重命名的UDisk的Id</param>                    
        /// <param name="udiskname">重命名UDisk的name</param>                    
        public RenameUDiskRequest(string region, string udiskid, string udiskname)
        {               
            Region = region;
            UDiskId = udiskid;
            UDiskName = udiskname;
        }                
    }
}
