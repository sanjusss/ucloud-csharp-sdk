namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名原始日志
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_domain_log.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnDomainLogSet
    {
        /// <summary>
        /// 流量获取的时间点 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// 具体获取日志连的URL 
        ///     <para>
        ///     其中获取最近7天内的下载日志。下载日志URL中的域名后带有cn表示中国大陆，hk表示香港，ov表示国外。创建加速域名时，aboard包含hk和ov。
        ///     </para>                 
        /// </summary>
        public string Value { get; set; }

    }
}
