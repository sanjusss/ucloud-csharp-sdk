namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建udb实例（包括mysql、mongodb实例和从备份恢复实例）
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/create_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class CreateUDBInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// db实例id                
        /// </summary>
        public string DBId { get; set; }

    }
}
