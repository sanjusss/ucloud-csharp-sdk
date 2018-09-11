namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建Bucket
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/create_bucket.html
    ///     </para>
    /// </summary>
    public partial class CreateBucketResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 已创建Bucket的名称                
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// 已创建Bucket的Id                
        /// </summary>
        public string BucketId { get; set; }

    }
}
