using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取指定数据中心镜像列表，用户可通过指定操作系统类型，镜像Id进行过滤。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_image.html
    ///     </para>
    /// </summary>
    public partial class DescribeImageResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DescribeImageResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 满足条件的镜像总数                
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// JSON格式的镜像列表                
        /// </summary>
        public List<DescribeImageSet> ImageSet { get; set; }

    }
}
