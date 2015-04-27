namespace UCloudSDK.Models
{
    /// <summary>
    /// 对象存储UFile操作后返回的HTTP Header
    /// </summary>
    public partial class ResponseHeader
    {
        /// <summary>
        /// 文件哈希值.
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// 会话Id.
        /// </summary>
        public string XSessionId { get; set; }

        /// <summary>
        /// 文件长度.
        /// </summary>
        public int ContentLength { get; set; }

        /// <summary>
        /// 文件类型.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// 文件的范围.
        /// </summary>
        public string ContentRange { get; set; }
    }
}