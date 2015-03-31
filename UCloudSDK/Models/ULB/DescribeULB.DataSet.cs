using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示负载均衡实例信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_ulb.html
    ///     </para>
    /// </summary>
    public partial class DescribeULBDataSet
    {
        /// <summary>
        /// 负载均衡实例的Id                
        /// </summary>
        public string ULBId { get; set; }

        /// <summary>
        /// 负载均衡实例的名字                
        /// </summary>
        public string ULBName { get; set; }

        /// <summary>
        /// 带宽模式 
        ///     <para>
        ///     枚举值为：0，该负载均衡实例非共享带宽；1，该负载均衡实例使用共享带宽
        ///     </para>                 
        /// </summary>
        public int BandwidthType { get; set; }

        /// <summary>
        /// 负载均衡的创建时间 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// 负载均衡实例的外网IP信息 
        ///     <para>
        ///     具体结构见下方IPSet
        ///     </para>                 
        /// </summary>
        public List<DescribeULBIPSet> IPSet { get; set; }

        /// <summary>
        /// 负载均衡实例中存在的VServer实例列表 
        ///     <para>
        ///     具体结构件下方VserverSet
        ///     </para>                 
        /// </summary>
        public List<DescribeULBVserverSet> VserverSet { get; set; }

    }
}
