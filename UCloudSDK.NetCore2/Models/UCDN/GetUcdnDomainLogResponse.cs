using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名原始日志
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_domain_log.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnDomainLogResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      GetUcdnDomainLogResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 流量实例表 
        ///     <para>
        ///     具体结构见 LogSet
        ///     </para>                 
        /// </summary>
        public List<GetUcdnDomainLogSet> LogSet { get; set; }

    }
}
