namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取指定数据中心镜像列表，用户可通过指定操作系统类型，镜像Id进行过滤。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_image.html
    ///     </para>
    /// </summary>
    public partial class DescribeImageRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeImage";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeImage
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
        /// 标准镜像 
        ///     <para>
        ///     Base，行业镜像：Business，自定义镜像：Custom，默认返回所有类型
        ///     </para>                 
        /// </summary>
        public string ImageType { get; set; }

        /// <summary>
        /// 操作系统类型 
        ///     <para>
        ///     Linux， Windows默认返回所有类型
        ///     </para>                 
        /// </summary>
        public string OsType { get; set; }

        /// <summary>
        /// 镜像Id                
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 数据偏移量 
        ///     <para>
        ///     默认为0
        ///     </para>                 
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// 返回数据长度 
        ///     <para>
        ///     默认为20
        ///     </para>                 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeImageRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeImageRequest(string region)
        {               
            Region = region;
        }                
    }
}
