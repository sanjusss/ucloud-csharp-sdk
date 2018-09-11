namespace UCloudSDK.Models
{
    /// <summary>
    /// UNet防火墙规则
    /// </summary>
    public partial class SecurityGroupRule
    {
        /// <summary>
        /// 网络协议 
        ///     <para>
        ///     枚举值为：TCP，UDP，ICMP，GRE
        ///     </para>                 
        /// </summary>
        public string Proto { get; set; }

        /// <summary>
        /// 目标端口 
        ///     <para>
        ///     范围：[1-65535]，可指定单个端口（如80），或指定端口段（1-1024）
        ///     </para>                 
        /// </summary>
        public string Dst_port { get; set; }

        /// <summary>
        /// 源地址 
        ///     <para>
        ///     格式为’x.x.x.x/x 或 x.x.x.x’的有效IP地址。
        ///     </para>                 
        /// </summary>
        public string Src_ip { get; set; }

        /// <summary>
        /// 防火墙动作 
        ///     <para>
        ///     枚举值为：ACCEPT：允许通过防火墙；DROP：禁止通过防火墙并不给任何返回信息
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 规则优先级 
        ///     <para>
        ///     枚举值为：0（高），50（中），100（低）
        ///     </para>                 
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// 返回Rule格式化字符串.
        ///     <para>
        ///     格式：Proto|Dst_port|Src_ip|Action|Priority
        ///     </para>
        /// </summary>
        /// <returns>
        /// Proto|Dst_port|Src_ip|Action|Priority.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}", Proto, Dst_port, Src_ip, Action, Priority);
        }

    }
}
