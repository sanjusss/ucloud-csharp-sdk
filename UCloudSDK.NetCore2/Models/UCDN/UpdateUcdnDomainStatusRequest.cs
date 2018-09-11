namespace UCloudSDK.Models
{
    /// <summary>
    /// 更新加速域名状态
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/update_ucdn_domain_status.html
    ///     </para>
    /// </summary>
    public partial class UpdateUcdnDomainStatusRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UpdateUcdnDomainStatus";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UpdateUcdnDomainStatus
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
        public string DomainId { get; set; }

        /// <summary>
        /// 域名状态 
        ///     <para>
        ///     enable代表加速中，disable代表停止加速，delete代表删除加速。（目前仅支持删除审核失败的域名）
        ///     </para>                 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdateUcdnDomainStatusRequest" /> 类.
        /// </summary>
        /// <param name="domainId">域名ID.</param>
        /// <param name="status">域名状态.</param>
        public UpdateUcdnDomainStatusRequest(string domainId, string status)
        {
            DomainId = domainId;
            Status = status;
        }

    }
}
