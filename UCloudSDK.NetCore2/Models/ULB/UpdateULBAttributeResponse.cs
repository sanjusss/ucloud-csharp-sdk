namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改负载均衡实例属性
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/update_ulb_attribute.html
    ///     </para>
    /// </summary>
    public partial class UpdateULBAttributeResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreateULBResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
