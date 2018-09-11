namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建防火墙组
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/create_security_group.html
    ///     </para>
    /// </summary>
    public partial class CreateSecurityGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateSecurityGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateSecurityGroup
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
        /// 防火墙组名称                
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 防火墙组描述                
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 防火墙规则 
        ///     <para>
        ///     格式如下：
        ///     </para>                 
        /// </summary>
        public NList Rule { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateSecurityGroupRequest" /> 类.
        /// </summary>
        /// <param name="region">数据中心</param>
        /// <param name="groupname">防火墙组名称</param>
        /// <param name="description">防火墙组描述.</param>
        /// <param name="rule">防火墙规则</param>
        public CreateSecurityGroupRequest(string region, string groupname, string description, NList rule)
        {               
            Region = region;
            GroupName = groupname;
            Description = description;
            Rule = rule;
        }                
    }
}
