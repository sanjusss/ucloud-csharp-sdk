namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示负载均衡实例信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_ulb.html
    ///     </para>
    /// </summary>
    public partial class DescribeULBSSLSet
    {
        /// <summary>
        /// SSL证书的ID                
        /// </summary>
        public string SSLId { get; set; }

        /// <summary>
        /// SSL证书的名称                
        /// </summary>
        public string SSLName { get; set; }

    }
}
