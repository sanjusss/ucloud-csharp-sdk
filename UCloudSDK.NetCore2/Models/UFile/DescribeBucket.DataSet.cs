using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取Bucket的描述信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/describe_bucket.html
    ///     </para>
    /// </summary>
    public partial class DescribeBucketDataSet
    {
        /// <summary>
        /// Bucket名称                
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Bucket的Id                
        /// </summary>
        public string BucketId { get; set; }

        /// <summary>
        /// Bucket的域名集合                
        /// </summary>
        public List<DescribeBucketDomain> Domain { get; set; }

        /// <summary>
        /// 与Bucket关联的CND加速域名的ID列表                
        /// </summary>
        public List<string> CdnDomainId { get; set; }

        /// <summary>
        /// Bucket访问类型                
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Bucket的创建时间                
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// Bucket的修改时间                
        /// </summary>
        public int ModifyTime { get; set; }

    }
}
