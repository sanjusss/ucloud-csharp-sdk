namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建加速域名
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/create_ucdn_domain.html
    ///     </para>
    /// </summary>
    public partial class CreateUcdnDomainRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateUcdnDomain";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateUcdnDomain
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
               
        /// <summary>
        /// 用于加速的域名                
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// 源站IP 
        ///     <para>
        ///     即cdn服务器回源访问的IP地址。支持多个源站IP。多个源站IP可以表述为：SourceIps.0=1.1.1.1，SourceIps.1=2.2.2.2（如果CdnType为live，则该字段非必须，否则该字段为必须字段）
        ///     </para>                 
        /// </summary>
        public NList SourceIp { get; set; }

        /// <summary>
        /// 测试url 
        ///     <para>
        ///     用于域名创建加速时的测试。（如果CdnType为live，则该字段非必须，否则该字段为必须字段）
        ///     </para>                 
        /// </summary>
        public string TestUrl { get; set; }

        /// <summary>
        /// CDN加速区域 
        ///     <para>
        ///     目前区域代表有：cn：国内；abroad：国外。可选择多个区域，表述为：Areacodes.0=cn, Areacodes.1=aboard。表示同时使用国内和海外节点
        ///     </para>                 
        /// </summary>
        public NList Areacode { get; set; }

        /// <summary>
        /// 加速域名的业务类型 
        ///     <para>
        ///     web代表网站，stream代表视频，download代表下载，Live代表直播
        ///     </para>                 
        /// </summary>
        public string CdnType { get; set; }

        /// <summary>
        /// 计费方式 
        ///     <para>
        ///     默认使用流量包计费。枚举值为：traffic：按流量包计费；bandwidth：按带宽计费；trafficused：代表流量后付费。（目前仅支持按流量包计费）
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 直播流数 
        ///     <para>
        ///     CdnType为live时，该字段为必须字段）
        ///     </para>                 
        /// </summary>
        public int? LiveStreamCount { get; set; }

        /// <summary>
        /// 直播类型 
        ///     <para>
        ///     枚举值为：rtmppush；rtmppull；hls（CdnType为live时，该字段为必须字段）
        ///     </para>                 
        /// </summary>
        public string LiveSrcType { get; set; }

        /// <summary>
        /// 用于获取流的源URL 
        ///     <para>
        ///     （LiveSrcType为rtmppull/hls时，该字段为必须字段）
        ///     </para>                 
        /// </summary>
        public string LifeSrcUrl { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateUcdnDomainRequest"/> 对象.
        /// </summary>
        /// <param name="domain">用于加速的域名.</param>
        /// <param name="areacodes">CDN加速区域.</param>
        /// <param name="cdnType">加速域名的业务类型.</param>
        public CreateUcdnDomainRequest(string domain, NList areacodes, string cdnType)
        {
            Domain = domain;
            Areacode = areacodes;
            CdnType = cdnType;
        } 
    }
}
