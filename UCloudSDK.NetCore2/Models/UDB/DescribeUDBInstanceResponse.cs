using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb实例信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// DB实例信息列表                
        /// </summary>
        public List<string> DataSet { get; set; }

        /// <summary>
        /// 用户db组的数量 
        ///     <para>
        ///     对于mysql: 主从结对数量，没有slave，则只有mastermongodb: 副本集数量
        ///     </para>                 
        /// </summary>
        public int TotalCount { get; set; }

    }
}
