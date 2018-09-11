namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名原始日志
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_domain_log.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnDomainLogRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "GetUcdnDomainLog";

        /// <summary>
        /// API名称
        ///     <para>
        ///     GetUcdnDomainLog
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

    }
}
