using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取弹性IP详细信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_eip.html
    ///     </para>
    /// </summary>
    public partial class DescribeEIPResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DescribeEIPResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 满足条件的弹性IP总数                
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 弹性IP列表 
        ///     <para>
        ///     每项参数详见DataSet
        ///     </para>                 
        /// </summary>
        public List<DescribeEIPSet> EIPSet { get; set; }

    }
}
