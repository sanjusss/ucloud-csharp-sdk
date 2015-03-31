namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建udb实例的slave
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/create_udb_slave.html
    ///     </para>
    /// </summary>
    public partial class CreateUDBSlaveResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 创建slave的DBId                
        /// </summary>
        public string DBId { get; set; }

    }
}
