namespace UCloudSDK.Models
{
    /// <summary>
    /// 更新防火墙规则
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/update_security_group.html
    ///     </para>
    /// </summary>
    public partial class UpdateSecurityGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UpdateSecurityGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UpdateSecurityGroup
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
        /// 防火墙资源ID                
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 防火墙规则 
        ///     <para>
        ///     格式如下
        ///     </para>                 
        /// </summary>
        public NList Rule { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdateSecurityGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="groupid">防火墙资源ID</param>                    
        /// <param name="rule">防火墙规则</param>                    
        public UpdateSecurityGroupRequest(string region, string groupid, NList rule)
        {               
            Region = region;
            GroupId = groupid;
            Rule = rule;
        }                
    }
}
