using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名详细信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/describe_ucdn_domain.html
    ///     </para>
    /// </summary>
    public partial class DescribeUcdnDomainResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      DescribeUcdnDomainResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 满足条件的条目数                
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取的域名信息 
        ///     <para>
        ///     具体结构见 DomainSet
        ///     </para>                 
        /// </summary>
        public List<DescribeUcdnDomainSet> DomainSet { get; set; }

    }
}
