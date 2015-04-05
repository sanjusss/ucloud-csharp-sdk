namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取参数组详细参数信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBParamGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUDBParamGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUDBParamGroup
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
        /// 参数组id 
        ///     <para>
        ///     如果指定则获取描述，否则是列表操作，需要指定Offset/Limit
        ///     </para>                 
        /// </summary>
        public int? GroupId { get; set; }

        /// <summary>
        /// 分页显示的起始偏移 
        ///     <para>
        ///     列表操作则指定
        ///     </para>                 
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// 分页显示的条目数 
        ///     <para>
        ///     列表操作则指定
        ///     </para>                 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeUDBParamGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeUDBParamGroupRequest(string region)
        {               
            Region = region;
        }                
    }
}
