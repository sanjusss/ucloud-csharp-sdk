namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改EIP名字业务组备注等属性字段
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/update_eip_attribute.html
    ///     </para>
    /// </summary>
    public partial class UpdateEIPAttributeResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     UpdateEIPAttributeResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
