namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb实例状态
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_instance_state.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBInstanceStateRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUDBInstanceState
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeUDBInstanceState";
            }
        }  
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     请参见数据中心RegionList
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 实例的Id                
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeUDBInstanceStateRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">实例的Id</param>                    
        public DescribeUDBInstanceStateRequest(string region, string dbid)
        {               
            Region = region;
            DBId = dbid;
        }                
    }
}
