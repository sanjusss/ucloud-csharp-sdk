namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取防火墙组信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_security_group.html
    ///     </para>
    /// </summary>
    public partial class DescribeSecurityGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeSecurityGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeSecurityGroup
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
        /// 绑定防火墙组的资源类型 
        ///     <para>
        ///     如uhost
        ///     </para>                 
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// 绑定防火墙组的资源ID                
        /// </summary>
        public int? ResourceId { get; set; }

        /// <summary>
        /// 防火墙ID                
        /// </summary>
        public int? GroupId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeSecurityGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeSecurityGroupRequest(string region)
        {               
            Region = region;
        }                
    }
}
