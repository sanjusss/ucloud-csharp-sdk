namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示负载均衡实例信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_ulb.html
    ///     </para>
    /// </summary>
    public partial class DescribeULBIPSet
    {
        /// <summary>
        /// 弹性IP的运营商信息 
        ///     <para>
        ///     枚举值为：Telecom：电信IP；Unicom：联通IP；Bgp：BGP IP；International：国际IP
        ///     </para>                 
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// 弹性IP的资源ID                
        /// </summary>
        public string EIPId { get; set; }

        /// <summary>
        /// 弹性IP的地址                
        /// </summary>
        public string EIP { get; set; }

    }
}
