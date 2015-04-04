namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取已经存在的UHost实例的存储快照列表。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_uhost_instance_snapshot.html
    ///     </para>
    /// </summary>
    public partial class DescribeUHostInstanceSnapshotRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUHostInstanceSnapshot";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUHostInstanceSnapshot
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
        /// 实例化 <see cref="DescribeUHostInstanceSnapshotRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        public DescribeUHostInstanceSnapshotRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
