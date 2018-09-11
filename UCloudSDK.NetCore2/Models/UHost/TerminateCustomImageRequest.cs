namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除用户自定义镜像
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/terminate_custom_image.html
    ///     </para>
    /// </summary>
    public partial class TerminateCustomImageRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "TerminateCustomImage";

        /// <summary>
        /// API名称
        ///     <para>
        ///     TerminateCustomImage
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        } 
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 自制镜像ID                
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 实例化 <see cref="TerminateCustomImageRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="imageid">自制镜像ID</param>                    
        public TerminateCustomImageRequest(string region, string imageid)
        {               
            Region = region;
            ImageId = imageid;
        }                
    }
}
