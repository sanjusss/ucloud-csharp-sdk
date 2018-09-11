using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取参数组详细参数信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBParamGroupDataSet
    {
        /// <summary>
        /// 参数组id                
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// 参数组名称                
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// DB类型id 
        ///     <para>
        ///     mysql/mongodb按版本细分各有一个id1：mysql-5.5，2：mysql-5.1，3：percona-5.54：mongodb-2.4，5：mongodb-2.6，6：mysql-5.67：percona-5.6
        ///     </para>                 
        /// </summary>
        public string DBTypeId { get; set; }

        /// <summary>
        /// 参数组描述                
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 参数组是否可修改 
        ///     <para>
        ///     默认值为true
        ///     </para>                 
        /// </summary>
        public bool Modifiable { get; set; }

        /// <summary>
        /// 参数的键值对                
        /// </summary>
        public List<DescribeUDBParamGroupParamMember> ParamMember { get; set; }

    }
}
