using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb实例价格信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_instance_price.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBInstancePriceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 价格                
        /// </summary>
        public List<DescribeUDBInstancePriceDataSet> DataSet { get; set; }

    }
}
