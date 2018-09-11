namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取弹性IP详细信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_eip.html
    ///     </para>
    /// </summary>
    public partial class DescribeEIPAddr
    {
        /// <summary>
        /// 弹性IP的运营商信息 
        ///     <para>
        ///     枚举值为：Telecom：电信IPUnicom：联通IPDuplet：双线IP（电信+联通）Bgp：BGP IPInternational：国际IP
        ///     </para>                 
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// 弹性IP地址                
        /// </summary>
        public string IP { get; set; }

    }
}
