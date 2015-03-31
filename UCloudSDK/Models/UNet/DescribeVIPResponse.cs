using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取内网VIP详细信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_vip.html
    ///     </para>
    /// </summary>
    public partial class DescribeVIPResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DescribeEIPResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 内网VIP地址列表                
        /// </summary>
        public List<string> DataSet { get; set; }

    }
}
