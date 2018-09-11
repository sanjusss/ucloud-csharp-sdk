using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 分片文件
    /// </summary>
    public partial class PartFile
    {
        /// <summary>
        /// 文件路径.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 签名.
        /// </summary>
        public string Auth { get; set; }

        /// <summary>
        /// 分片的块大小.
        /// </summary>
        public int BlkSize { get; set; }

        /// <summary>
        /// 上传文件在Bucket中的Key名称.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 上传文件所属Bucket的名称.
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// 是否为最后一块分片.
        /// </summary>
        public bool IsLast { get; set; }

        /// <summary>
        /// 文件MD5.
        /// </summary>
        public string Md5 { get; set; }

        /// <summary>
        /// 本次分片上传的上传Id.
        /// </summary>
        public string UploadId { get; set; }

        /// <summary>
        /// 分片的Etag列表.
        /// </summary>
        public SortedDictionary<int, string> Etags { get; set; }

        /// <summary>
        /// 分片编号.
        /// </summary>
        public int PartNumber { get; set; }

        /// <summary>
        /// 文件的MIME.
        /// </summary>
        public string Mime { get; set; }
    }
}
