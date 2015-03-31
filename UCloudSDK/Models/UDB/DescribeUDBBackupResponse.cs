using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 列表udb实例备份信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_backup.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBBackupResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 备份信息                
        /// </summary>
        public List<DescribeUDBBackupDataSet> DataSet { get; set; }

        /// <summary>
        /// 备份总数 
        ///     <para>
        ///     如果指定dbid，则是该db备份总数
        ///     </para>                 
        /// </summary>
        public int TotalCount { get; set; }

    }
}
