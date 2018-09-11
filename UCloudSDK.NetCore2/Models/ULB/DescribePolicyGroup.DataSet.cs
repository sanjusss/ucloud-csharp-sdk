using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示内容转发策略组详情
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_policy_group.html
    ///     </para>
    /// </summary>
    public partial class DescribePolicyGroupDataSet
    {
        /// <summary>
        /// 内容转发策略组ID                
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 内容转发策略组名称                
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 内容转发策略组详细信息 
        ///     <para>
        ///     具体结构见PolicySet
        ///     </para>                 
        /// </summary>
        public List<DescribePolicyGroupPolicySet> PolicySet { get; set; }

    }
}
