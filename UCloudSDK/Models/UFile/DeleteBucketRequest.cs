namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除Bucket
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/delete_bucket.html
    ///     </para>
    /// </summary>
    public partial class DeleteBucketRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DeleteBucket";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DeleteBucket
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        } 
               
        /// <summary>
        /// 待删除Bucket的名称                
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// 实例化 <see cref="DeleteBucketRequest"/> 类.
        /// </summary>
        /// <param name="bucketname">待删除Bucket的名称</param>                    
        public DeleteBucketRequest(string bucketname)
        {               
            BucketName = bucketname;
        }                
    }
}
