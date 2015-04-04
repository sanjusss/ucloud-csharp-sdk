namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名带宽使用信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_domain_bandwidth.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnDomainBandwidthRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "GetUcdnDomainBandwidth";

        /// <summary>
        /// API名称
        ///     <para>
        ///     GetUcdnDomainBandwidth
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        } 
               
        /// <summary>
        /// 域名ID 
        ///     <para>
        ///     创建加速域名时生成。
        ///     </para>                 
        /// </summary>
        public NList DomainId { get; set; }

        /// <summary>
        /// CDN加速区域 
        ///     <para>
        ///     目前区域代表有：cn：国内；abroad：国外。可选择多个区域，表述为：”Areacodes.0=cn, Areacodes.1=aboard”，表示同时使用国内和海外节点
        ///     </para>                 
        /// </summary>
        public NList Areacode { get; set; }

        /// <summary>
        /// 查询的起始时间 
        ///     <para>
        ///     格式为Unix Timestamp。如果有EndTime，BeginTime必须赋值。
        ///     </para>                 
        /// </summary>
        public int? BeginTime { get; set; }

        /// <summary>
        /// 查询的结束时间 
        ///     <para>
        ///     格式为Unix Timestamp。EndTime默认为当前时间，BeginTime默认为当前时间前一天时间。
        ///     </para>                 
        /// </summary>
        public int? EndTime { get; set; }

        /// <summary>
        /// 是否按天展示带宽峰值 
        ///     <para>
        ///     枚举值：0：否；1：是；默认为0
        ///     </para>                 
        /// </summary>
        public int? Daily { get; set; }

    }
}
