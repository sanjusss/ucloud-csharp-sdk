namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb支持的类型信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_type.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBTypeRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUDBType";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUDBType
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
        /// 实例化 <see cref="DescribeUDBTypeRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeUDBTypeRequest(string region)
        {               
            Region = region;
        }                
    }
}
