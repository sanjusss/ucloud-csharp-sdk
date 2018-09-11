using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb支持的类型信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_type.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBTypeResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// DB类型列表                
        /// </summary>
        public List<DescribeUDBTypeDataSet> DataSet { get; set; }

    }
}
