using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udisk实例价格信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/describe_udisk_price.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDiskPriceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 价格                
        /// </summary>
        public List<DescribeUDiskPriceDataSet> DataSet { get; set; }

    }
}
