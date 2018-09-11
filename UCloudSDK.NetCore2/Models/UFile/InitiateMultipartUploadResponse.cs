namespace UCloudSDK.Models
{
    /// <summary>
    /// 初始化分片上传
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/initiate_multipart_upload.html
    ///     </para>
    /// </summary>
    public partial class InitiateMultipartUploadResponse : UResponse
    {
        /// <summary>
        /// 本次分片上传的上传Id                
        /// </summary>
        public string UploadId { get; set; }

        /// <summary>
        /// 分片的块大小                
        /// </summary>
        public int BlkSize { get; set; }

        /// <summary>
        /// 上传文件所属Bucket的名称                
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// 上传文件在Bucket中的Key名称                
        /// </summary>
        public string Key { get; set; }

    }
}
