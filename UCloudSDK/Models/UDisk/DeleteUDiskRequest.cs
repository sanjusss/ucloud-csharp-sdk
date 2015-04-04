namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除UDisk
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/delete_udisk.html
    ///     </para>
    /// </summary>
    public partial class DeleteUDiskRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DeleteUDisk";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DeleteUDisk
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
        /// 要删除的UDisk的Id                
        /// </summary>
        public string UDiskId { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DeleteUDiskRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="udiskid">要删除的UDisk的Id</param>                    
        public DeleteUDiskRequest(string region, string udiskid)
        {               
            Region = region;
            UDiskId = udiskid;
        }                
    }
}
