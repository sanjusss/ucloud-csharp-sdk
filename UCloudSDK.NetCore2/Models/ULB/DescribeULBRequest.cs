namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示负载均衡实例信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_ulb.html
    ///     </para>
    /// </summary>
    public partial class DescribeULBRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeULB";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeULB
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
        /// 负载均衡实例的ID 
        ///     <para>
        ///     若指定则返回指定的负载均衡实例信息；若不指定则返回用户当前数据中心中所有负载均衡实例的信息
        ///     </para>                 
        /// </summary>
        public string ULBId { get; set; }

        /// <summary>
        /// 数据偏移量 
        ///     <para>
        ///     默认为0
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
        /// 实例化 <see cref="DescribeULBRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeULBRequest(string region)
        {               
            Region = region;
        }                
    }
}
