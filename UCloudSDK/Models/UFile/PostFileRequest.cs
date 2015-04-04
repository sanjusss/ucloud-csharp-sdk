namespace UCloudSDK.Models
{
    /// <summary>
    /// 表单上传文件
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/post_file.html
    ///     </para>
    /// </summary>
    public partial class PostFileRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "PostFile";

        /// <summary>
        /// API名称
        ///     <para>
        ///     PostFile
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }

        /// <summary>
        /// Bucket中文件的名称                
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 上传请求的授权签名                
        /// </summary>
        public string Authorization { get; set; }

        /// <summary>
        /// 上传文件本身的MimeType                
        /// </summary>
        public string Content__Type { get; set; }

        /// <summary>
        /// 实例化 <see cref="PostFileRequest"/> 类.
        /// </summary>
        /// <param name="filename">Bucket中文件的名称</param>                    
        /// <param name="authorization">上传请求的授权签名</param>                    
        public PostFileRequest(string filename, string authorization)
        {
            FileName = filename;
            Authorization = authorization;
        }
    }
}
