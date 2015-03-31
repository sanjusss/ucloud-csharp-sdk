namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改VServer实例属性
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/update_vserver_attribute.html
    ///     </para>
    /// </summary>
    public partial class UpdateVServerAttributeResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     UpdateVServerAttributeResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
