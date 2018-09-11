namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取内网VIP详细信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_vip.html
    ///     </para>
    /// </summary>
    public partial class DescribeVIPRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeVIP";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeVIP
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
        /// 实例化 <see cref="DescribeVIPRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeVIPRequest(string region)
        {               
            Region = region;
        }                
    }
}
