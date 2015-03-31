namespace UCloudSDK.Models
{
    /// <summary>
    /// 释放VIP资源
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/release_vip.html
    ///     </para>
    /// </summary>
    public partial class ReleaseVIPResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ReleaseVIPResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
