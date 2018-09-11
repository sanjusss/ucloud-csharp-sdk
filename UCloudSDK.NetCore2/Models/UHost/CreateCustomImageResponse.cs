namespace UCloudSDK.Models
{
    /// <summary>
    /// 从指定UHost实例，生成自定义镜像。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/create_custom_image.html
    ///     </para>
    /// </summary>
    public partial class CreateCustomImageResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreateCustomImageResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 镜像Id                
        /// </summary>
        public string ImageId { get; set; }

    }
}
