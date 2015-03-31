namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb支持的类型信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_type.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBTypeDataSet
    {
        /// <summary>
        /// DB类型id 
        ///     <para>
        ///     mysql/mongodb按版本细分各有一个id1：mysql-5.5，2：mysql-5.1，3：percona-5.54：mongodb-2.4，5：mongodb-2.6，6：mysql-5.6，7：percona-5.6
        ///     </para>                 
        /// </summary>
        public string DBTypeId { get; set; }

    }
}
