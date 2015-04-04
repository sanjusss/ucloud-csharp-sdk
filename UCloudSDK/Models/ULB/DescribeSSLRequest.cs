namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示SSL证书信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_ssl.html
    ///     </para>
    /// </summary>
    public partial class DescribeSSLRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeSSL";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeSSL
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// SSL证书的Id                
        /// </summary>
        public string SSLId { get; set; }

        /// <summary>
        /// 数据分页值 
        ///     <para>
        ///     默认为20
        ///     </para>                 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// 数据偏移量 
        ///     <para>
        ///     默认值为0
        ///     </para>                 
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeSSLRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeSSLRequest(string region)
        {               
            Region = region;
        }                
    }
}
