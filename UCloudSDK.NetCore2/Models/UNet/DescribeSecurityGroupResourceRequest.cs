namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取防火墙组所绑定资源的外网IP
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_security_group_resource.html
    ///     </para>
    /// </summary>
    public partial class DescribeSecurityGroupResourceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeSecurityGroupResource";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeSecurityGroupResource
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }

        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 防火墙ID                
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeSecurityGroupResourceRequest" /> 类.
        /// </summary>
        /// <param name="region">数据中心</param>
        /// <param name="groupid">防火墙ID.</param>
        public DescribeSecurityGroupResourceRequest(string region, string groupid)
        {               
            Region = region;
            GroupId = groupid;
        }
    }
}
