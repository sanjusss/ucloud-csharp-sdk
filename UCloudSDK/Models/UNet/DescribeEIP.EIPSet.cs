using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取弹性IP详细信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_eip.html
    ///     </para>
    /// </summary>
    public partial class DescribeEIPSet
    {
        /// <summary>
        /// 弹性IP的资源ID                
        /// </summary>
        public string EIPId { get; set; }

        /// <summary>
        /// 外网出口权重 
        ///     <para>
        ///     默认为50，范围[0-100]
        ///     </para>                 
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 带宽模式 
        ///     <para>
        ///     枚举值为：0：非共享带宽模式，1：共享带宽模式
        ///     </para>                 
        /// </summary>
        public int BandwidthType { get; set; }

        /// <summary>
        /// 弹性IP的带宽 
        ///     <para>
        ///     单位为Mbps，当BandwidthType=1时，该处显示为共享带宽值。
        ///     </para>                 
        /// </summary>
        public int Bandwidth { get; set; }

        /// <summary>
        /// 弹性IP的资源绑定状态 
        ///     <para>
        ///     枚举值为：used：已绑定，free：未绑定
        ///     </para>                 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 计费模式 
        ///     <para>
        ///     枚举值为：Year，按年付费；Month，按月付费；Dynamic，按小时付费；Trial，试用
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 弹性IP的创建时间 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// 弹性IP的到期时间 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public int ExpireTime { get; set; }

        /// <summary>
        /// 弹性IP的详细信息列表 
        ///     <para>
        ///     具体结构见下方Resource
        ///     </para>                 
        /// </summary>
        public List<DescribeEIPResource> Resource { get; set; }

        /// <summary>
        /// 弹性IP的详细信息列表 
        ///     <para>
        ///     具体结构见下方EIPAddr
        ///     </para>                 
        /// </summary>
        public List<DescribeEIPAddr> EIPAddr { get; set; }

    }
}
