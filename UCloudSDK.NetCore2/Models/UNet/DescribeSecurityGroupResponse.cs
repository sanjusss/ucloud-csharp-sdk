using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取防火墙组信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_security_group.html
    ///     </para>
    /// </summary>
    public partial class DescribeSecurityGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DescribeSecurityGroupResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 获取的防火墙组详细信息                
        /// </summary>
        public List<DescribeSecurityGroupDataSet> DataSet { get; set; }

    }
}
