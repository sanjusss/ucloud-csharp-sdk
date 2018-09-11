namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取指定数据中心镜像列表，用户可通过指定操作系统类型，镜像Id进行过滤。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_image.html
    ///     </para>
    /// </summary>
    public partial class DescribeImageSet
    {
        /// <summary>
        /// 镜像ID                
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像名称                
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// 操作系统类型 
        ///     <para>
        ///     Liunx，Windows
        ///     </para>                 
        /// </summary>
        public string OsType { get; set; }

        /// <summary>
        /// 操作系统名称                
        /// </summary>
        public string OsName { get; set; }

        /// <summary>
        /// 标准镜像 
        ///     <para>
        ///     Base，行业镜像：Business，自定义镜像：Custom
        ///     </para>                 
        /// </summary>
        public string ImageType { get; set; }

        /// <summary>
        /// 镜像状态 
        ///     <para>
        ///     可用：Available，制作中：Making，不可用：Unavailable
        ///     </para>                 
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 镜像描述                
        /// </summary>
        public string ImageDescription { get; set; }

        /// <summary>
        /// 创建时间                
        /// </summary>
        public int CreateTime { get; set; }

    }
}
