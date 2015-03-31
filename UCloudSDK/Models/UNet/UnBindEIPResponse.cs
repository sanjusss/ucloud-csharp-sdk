namespace UCloudSDK.Models
{
    /// <summary>
    /// 将弹性IP从资源上解绑
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/unbind_eip.html
    ///     </para>
    /// </summary>
    public partial class UnBindEIPResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     UnBindEIPResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
