namespace UCloudSDK.Models
{
    /// <summary>
    /// 从指定UHost实例，生成自定义镜像。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/create_custom_image.html
    ///     </para>
    /// </summary>
    public partial class CreateCustomImageRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateCustomImage";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateCustomImage
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
        /// UHost实例ID                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// 镜像名称                
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// 镜像描述                
        /// </summary>
        public string ImageDescription { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateCustomImageRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        /// <param name="imagename">镜像名称</param>                    
        public CreateCustomImageRequest(string region, string uhostid, string imagename)
        {               
            Region = region;
            UHostId = uhostid;
            ImageName = imagename;
        }                
    }
}
