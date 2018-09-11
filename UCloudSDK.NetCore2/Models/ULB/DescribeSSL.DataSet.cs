namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示SSL证书信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_ssl.html
    ///     </para>
    /// </summary>
    public partial class DescribeSSLDataSet
    {
        /// <summary>
        /// 证书的ID                
        /// </summary>
        public string SSLId { get; set; }

        /// <summary>
        /// 证书的名字                
        /// </summary>
        public string SSLName { get; set; }

        /// <summary>
        /// 证书的类型 
        ///     <para>
        ///     枚举值为：0：Pem格式
        ///     </para>                 
        /// </summary>
        public string SSLType { get; set; }

        /// <summary>
        /// 证书的内容                
        /// </summary>
        public string SSLContent { get; set; }

        /// <summary>
        /// 证书的HASH值                
        /// </summary>
        public string HashValue { get; set; }

        /// <summary>
        /// 创建时间 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// 所绑定VServer的资源ID                
        /// </summary>
        public string VServerId { get; set; }

    }
}
