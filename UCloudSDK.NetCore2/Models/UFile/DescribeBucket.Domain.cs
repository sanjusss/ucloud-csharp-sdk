using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取Bucket的描述信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/describe_bucket.html
    ///     </para>
    /// </summary>
    public partial class DescribeBucketDomain
    {
        /// <summary>
        /// 源站域名                
        /// </summary>
        public List<string> Src { get; set; }

        /// <summary>
        /// UCDN加速域名                
        /// </summary>
        public List<string> Cdn { get; set; }

        /// <summary>
        /// 用户自定义源站域名                
        /// </summary>
        public List<string> CustomSrc { get; set; }

        /// <summary>
        /// 用户自定义CDN加速域名                
        /// </summary>
        public List<string> CustomCdn { get; set; }

    }
}
