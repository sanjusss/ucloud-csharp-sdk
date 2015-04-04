namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建内容转发策略组
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/create_policy_group.html
    ///     </para>
    /// </summary>
    public partial class CreatePolicyGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreatePolicyGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreatePolicyGroup
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
        /// 内容转发策略组名称 
        ///     <para>
        ///     默认为空
        ///     </para>                 
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreatePolicyGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public CreatePolicyGroupRequest(string region)
        {               
            Region = region;
        }                
    }
}
