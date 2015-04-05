namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb实例信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUDBInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUDBInstance
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
        ///     请参见数据中心RegionList
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public int? ProjectId { get; set; }

        /// <summary>
        /// DB实例id 
        ///     <para>
        ///     如果指定则获取描述，否则为列表操作，指定Offset/Limit
        ///     </para>                 
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// DB种类 
        ///     <para>
        ///     分为SQL和NOSQL，如果是别表操作，则需要制定
        ///     </para>                 
        /// </summary>
        public string ClassType { get; set; }

        /// <summary>
        /// 分页显示起始偏移位置 
        ///     <para>
        ///     列表操作则指定
        ///     </para>                 
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// 分页显示数量 
        ///     <para>
        ///     列表操作则指定
        ///     </para>                 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeUDBInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeUDBInstanceRequest(string region)
        {               
            Region = region;
        }                
    }
}
