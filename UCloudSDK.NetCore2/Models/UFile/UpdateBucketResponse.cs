namespace UCloudSDK.Models
{
    /// <summary>
    /// 设置Bucket的属性
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/update_bucket.html
    ///     </para>
    /// </summary>
    public partial class UpdateBucketResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }
    }
}
