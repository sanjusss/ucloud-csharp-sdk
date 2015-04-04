namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示内容转发策略组详情
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_policy_group.html
    ///     </para>
    /// </summary>
    public partial class DescribePolicyGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribePolicyGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribePolicyGroup
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
        /// 内容转发策略组ID                
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 数据偏移量 
        ///     <para>
        ///     默认值为0
        ///     </para>                 
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// 数据分页值 
        ///     <para>
        ///     默认为20
        ///     </para>                 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribePolicyGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribePolicyGroupRequest(string region)
        {               
            Region = region;
        }                
    }
}
