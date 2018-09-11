using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取UDisk实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/describe_udisk.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDiskResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// JSON 格式的UDisk数据列表 
        ///     <para>
        ///      每项参数可见下面 ResponseItem
        ///     </para>                 
        /// </summary>
        public List<DescribeUDiskDataSet> DataSet { get; set; }

        /// <summary>
        /// 根据过滤条件得到的总数                
        /// </summary>
        public int TotalCount { get; set; }

    }
}
