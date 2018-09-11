namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取主机或主机列表信息，并可根据数据中心，主机ID等参数进行过滤。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class DescribeUHostInstanceIPSet
    {
        /// <summary>
        /// 电信 
        ///     <para>
        ///      China-telecom，联通: China-unicom，国际: Internation，BGP: Bgp，内网: Private双线: Duplet
        ///     </para>                 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// IP资源ID (内网IP无对应的资源ID)                
        /// </summary>
        public string IPId { get; set; }

        /// <summary>
        /// IP地址                
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// IP对应的带宽 
        ///     <para>
        ///      单位: Mb (内网IP不显示带宽信息)
        ///     </para>                 
        /// </summary>
        public int bandwidth { get; set; }

    }
}
