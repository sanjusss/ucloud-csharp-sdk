namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建mongodb的副本节点（包括仲裁）
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/create_udb_replication_instance.html
    ///     </para>
    /// </summary>
    public partial class CreateUDBReplicationInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 创建从节点的DBId                
        /// </summary>
        public string DBId { get; set; }

    }
}
