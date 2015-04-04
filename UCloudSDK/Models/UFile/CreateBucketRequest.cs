namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建Bucket
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/create_bucket.html
    ///     </para>
    /// </summary>
    public partial class CreateBucketRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateBucket";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateBucket
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
               
        /// <summary>
        /// 待创建Bucket的名称 
        ///     <para>
        ///     BucketName参数将构成域名的一部分(与Bucket默认关联的域名为&lt;BucketName&gt;.ufile.ucloud.cn)，必须具有全局唯一性。 BucketName参数必须符合Bucket名称规范,规范如下: (1) 长度在3~63字节之间； (2) 可以由多个标签组成，各个标签用 . 间隔，每个标签只能包含小字母、数字、连接符（短横线），并且标签的开头和结尾的字符只能是小写字母或数字； (3) 不可以是IP地址。
        ///     </para>                 
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Bucket访问类型 
        ///     <para>
        ///     public或private; 默认为private
        ///     </para>                 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Bucket的自定义域名                
        /// </summary>
        public NList Domain { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateBucketRequest"/> 类.
        /// </summary>
        /// <param name="bucketname">待创建Bucket的名称</param>                    
        public CreateBucketRequest(string bucketname)
        {               
            BucketName = bucketname;
        }                
    }
}
