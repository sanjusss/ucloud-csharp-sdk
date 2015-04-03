using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取Bucket的描述信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/describe_bucket.html
    ///     </para>
    /// </summary>
    public partial class DescribeBucketResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Bucket的描述信息                
        /// </summary>
        public List<DescribeBucketDataSet> DataSet { get; set; }

    }
}
