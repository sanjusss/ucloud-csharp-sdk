namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取防火墙组信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_security_group.html
    ///     </para>
    /// </summary>
    public partial class DescribeSecurityGroupRule
    {
        /// <summary>
        /// 源地址                
        /// </summary>
        public string SrcIP { get; set; }

        /// <summary>
        /// 优先级                
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// 协议类型                
        /// </summary>
        public string ProtocolType { get; set; }

        /// <summary>
        /// 目标端口                
        /// </summary>
        public string DstPort { get; set; }

        /// <summary>
        /// 防火墙动作                
        /// </summary>
        public string RuleAction { get; set; }

    }
}
