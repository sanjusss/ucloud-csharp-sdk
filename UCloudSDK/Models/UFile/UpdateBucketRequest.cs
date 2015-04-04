namespace UCloudSDK.Models
{
    /// <summary>
    /// 设置Bucket的属性
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/update_bucket.html
    ///     </para>
    /// </summary>
    public partial class UpdateBucketRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UpdateBucket";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UpdateBucket
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        } 
               
        /// <summary>
        /// 待修改Bucket的名称                
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Bucket访问类型                
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdateBucketRequest"/> 类.
        /// </summary>
        /// <param name="bucketname">待修改Bucket的名称</param>                    
        public UpdateBucketRequest(string bucketname)
        {               
            BucketName = bucketname;
        }                
    }
}
