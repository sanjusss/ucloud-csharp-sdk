namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名详细信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/describe_ucdn_domain.html
    ///     </para>
    /// </summary>
    public partial class DescribeUcdnDomainRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUcdnDomain";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUcdnDomain
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
        ///     创建加速域名时生成。默认获取账户下所有域名。
        ///     </para>                 
        /// </summary>
        public NList DomainIds { get; set; }

        /// <summary>
        /// 返回数据的偏移量 
        ///     <para>
        ///     默认0。
        ///     </para>                 
        /// </summary>
        public int? OffSet { get; set; }

        /// <summary>
        /// 返回数据的长度 
        ///     <para>
        ///     默认20。
        ///     </para>                 
        /// </summary>
        public string Limit { get; set; }

    }
}
