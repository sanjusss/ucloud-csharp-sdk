namespace UCloudSDK.Models
{
    /// <summary>
    /// 对指定UHost实例制作数据快照。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/create_uhost_instance_snapshot.html
    ///     </para>
    /// </summary>
    public partial class CreateUHostInstanceSnapshotRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateUHostInstanceSnapshot";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateUHostInstanceSnapshot
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
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateUHostInstanceSnapshotRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        public CreateUHostInstanceSnapshotRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
