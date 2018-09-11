namespace UCloudSDK.Models
{
    /// <summary>
    /// 重命名udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/modify_udb_instance_name.html
    ///     </para>
    /// </summary>
    public partial class ModifyUDBInstanceNameResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
