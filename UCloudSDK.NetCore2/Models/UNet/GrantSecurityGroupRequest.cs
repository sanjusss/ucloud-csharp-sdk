namespace UCloudSDK.Models
{
    /// <summary>
    /// 将防火墙应用到资源上
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/grant_security_group.html
    ///     </para>
    /// </summary>
    public partial class GrantSecurityGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "GrantSecurityGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     GrantSecurityGroup
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
        /// 所应用资源类型 
        ///     <para>
        ///     如UHost
        ///     </para>                 
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// 所应用资源ID                
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// 实例化 <see cref="GrantSecurityGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="groupid">防火墙资源ID</param>                    
        /// <param name="resourcetype">所应用资源类型</param>                    
        /// <param name="resourceid">所应用资源ID</param>                    
        public GrantSecurityGroupRequest(string region, string groupid, string resourcetype, string resourceid)
        {               
            Region = region;
            GroupId = groupid;
            ResourceType = resourcetype;
            ResourceId = resourceid;
        }                
    }
}
