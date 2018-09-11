namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取Bucket的文件列表
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/get_file_list.html
    ///     </para>
    /// </summary>
    public partial class GetFileListDataSet
    {
        /// <summary>
        /// 文件所属Bucket的名称                
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Bucket中文件的名称                
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件的哈希值 
        ///     <para>
        ///     默认为md5
        ///     </para>                 
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// 文件的MIME类型                
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// 文件大小                
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 文件创建时间                
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// 文件修改时间                
        /// </summary>
        public int ModifyTime { get; set; }

    }
}
