namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除用户自定义镜像
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/terminate_custom_image.html
    ///     </para>
    /// </summary>
    public partial class TerminateCustomImageResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     TerminateCustomImageResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 自制镜像Id                
        /// </summary>
        public string ImageId { get; set; }

    }
}
