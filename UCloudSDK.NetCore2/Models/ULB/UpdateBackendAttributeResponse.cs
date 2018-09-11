namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改ULB后端资源实例(主机池)属性
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/update_backend_attribute.html
    ///     </para>
    /// </summary>
    public partial class UpdateBackendAttributeResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     UpdateBackendAttributeResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
