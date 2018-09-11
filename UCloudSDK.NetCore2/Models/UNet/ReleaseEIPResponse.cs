namespace UCloudSDK.Models
{
    /// <summary>
    /// 释放EIP资源
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/release_eip.html
    ///     </para>
    /// </summary>
    public partial class ReleaseEIPResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ReleaseEIPResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
