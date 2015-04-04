namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除防火墙
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/delete_security_group.html
    ///     </para>
    /// </summary>
    public partial class DeleteSecurityGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DeleteSecurityGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DeleteSecurityGroup
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
        /// 实例化 <see cref="DeleteSecurityGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="groupid">防火墙资源ID</param>                    
        public DeleteSecurityGroupRequest(string region, string groupid)
        {               
            Region = region;
            GroupId = groupid;
        }                
    }
}
