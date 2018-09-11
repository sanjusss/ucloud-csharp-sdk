using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示内容转发策略组详情
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_policy_group.html
    ///     </para>
    /// </summary>
    public partial class DescribePolicyGroupPolicySet
    {
        /// <summary>
        /// 内容转发策略组ID                
        /// </summary>
        public string PolicyId { get; set; }

        /// <summary>
        /// 内容转发匹配字段的类型 
        ///     <para>
        ///     当前只支持按域名转发。枚举值为：Domain，按域名转发
        ///     </para>                 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 内容转发匹配字段                
        /// </summary>
        public string Match { get; set; }

        /// <summary>
        /// 内容转发策略组ID应用的VServer实例的ID                
        /// </summary>
        public string VServerId { get; set; }

        /// <summary>
        /// 内容转发策略组ID所应用的后端资源列表 
        ///     <para>
        ///     具体结构见”BackendSet”
        ///     </para>                 
        /// </summary>
        public List<DescribePolicyGroupBackendSet> BackendSet { get; set; }

    }
}
