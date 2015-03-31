using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示内容转发策略组详情
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_policy_group.html
    ///     </para>
    /// </summary>
    public partial class DescribePolicyGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DescribePolicyGroupResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 内容转发策略组列表 
        ///     <para>
        ///     具体结构见DataSet
        ///     </para>                 
        /// </summary>
        public List<DescribePolicyGroupDataSet> DataSet { get; set; }

    }
}
