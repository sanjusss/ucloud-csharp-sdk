namespace UCloudSDK.Models
{
    /// <summary>
    /// 上传文件分片
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/upload_part.html
    ///     </para>
    /// </summary>
    public partial class UploadPartResponse : FileResponse
    {
        /// <summary>
        /// 本次分片上传的分片号码                
        /// </summary>
        public int PartNumber { get; set; }

    }
}
