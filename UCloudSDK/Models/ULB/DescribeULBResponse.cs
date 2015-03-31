using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示负载均衡实例信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_ulb.html
    ///     </para>
    /// </summary>
    public partial class DescribeULBResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DescribeULBResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 满足条件的负载均衡实例的总数                
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 负载均衡实例列表 
        ///     <para>
        ///     具体结构见下方DataSet
        ///     </para>                 
        /// </summary>
        public List<DescribeULBDataSet> DataSet { get; set; }

    }
}
