namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取Bucket的文件列表
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/get_file_list.html
    ///     </para>
    /// </summary>
    public partial class GetFileListRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "GetFileList";

        /// <summary>
        /// API名称
        ///     <para>
        ///     GetFileList
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        } 
               
        /// <summary>
        /// Bucket名称                
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// 获取Bucket中文件列表的偏移数目 
        ///     <para>
        ///     默认为0
        ///     </para>                 
        /// </summary>
        public string Offset { get; set; }

        /// <summary>
        /// 获取Bucket中文件列表的限制数目 
        ///     <para>
        ///     默认为20
        ///     </para>                 
        /// </summary>
        public string Limit { get; set; }

        /// <summary>
        /// 实例化 <see cref="GetFileListRequest"/> 类.
        /// </summary>
        /// <param name="bucketname">Bucket名称</param>                    
        public GetFileListRequest(string bucketname)
        {               
            BucketName = bucketname;
        }                
    }
}
