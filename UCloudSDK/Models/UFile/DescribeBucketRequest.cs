namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取Bucket的描述信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/describe_bucket.html
    ///     </para>
    /// </summary>
    public partial class DescribeBucketRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeBucket";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeBucket
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
               
        /// <summary>
        /// 待获取Bucket的名称 
        ///     <para>
        ///     若不提供，则获取所有Bucket
        ///     </para>                 
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// 获取所有Bucket列表的偏移数目 
        ///     <para>
        ///     默认为0
        ///     </para>                 
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// 获取所有Bucket列表的限制数目 
        ///     <para>
        ///     默认为20
        ///     </para>                 
        /// </summary>
        public int? Limit { get; set; }

    }
}
