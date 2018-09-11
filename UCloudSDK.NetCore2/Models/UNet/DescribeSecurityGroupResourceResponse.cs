using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取防火墙组所绑定资源的外网IP
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_security_group_resource.html
    ///     </para>
    /// </summary>
    public partial class DescribeSecurityGroupResourceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DescribeSecurityGroupResourceResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// IP列表数组 如 [“10 
        ///     <para>
        ///     10.10.10”, “10.10.10.11”]
        ///     </para>                 
        /// </summary>
        public List<string> DataSet { get; set; }

    }
}
