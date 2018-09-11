namespace UCloudSDK.Models
{
    /// <summary>
    /// 完成分片上传
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/finish_multipart_upload.html
    ///     </para>
    /// </summary>
    public partial class FinishMultipartUploadResponse : FileResponse
    {
        /// <summary>
        /// 已上传文件所属Bucket的名称                
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// 已上传文件在Bucket中的Key名称                
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 已上传文件的大小                
        /// </summary>
        public int FileSize { get; set; }

    }
}
