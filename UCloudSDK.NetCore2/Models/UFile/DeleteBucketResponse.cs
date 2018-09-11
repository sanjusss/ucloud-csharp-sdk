namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除Bucket
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/delete_bucket.html
    ///     </para>
    /// </summary>
    public partial class DeleteBucketResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
