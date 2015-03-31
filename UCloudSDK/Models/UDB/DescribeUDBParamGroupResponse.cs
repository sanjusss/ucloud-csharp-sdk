using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取参数组详细参数信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBParamGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 参数组                
        /// </summary>
        public List<DescribeUDBParamGroupDataSet> DataSet { get; set; }

        /// <summary>
        /// 参数组总数 
        ///     <para>
        ///     列表操作时才会有该参数
        ///     </para>                 
        /// </summary>
        public int TotalCount { get; set; }

    }
}
