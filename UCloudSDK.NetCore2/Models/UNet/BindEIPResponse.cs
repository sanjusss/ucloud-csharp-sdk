namespace UCloudSDK.Models
{
    /// <summary>
    /// 将弹性IP绑定到资源上
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/bind_eip.html
    ///     </para>
    /// </summary>
    public partial class BindEIPResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     BindEIPResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
