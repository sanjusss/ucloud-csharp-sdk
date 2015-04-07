namespace UCloudSDK.Models
{
    /// <summary>
    /// 重置UHost实例的管理员密码。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/reset_uhost_instance_password.html
    ///     </para>
    /// </summary>
    public partial class ResetUHostInstancePasswordRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ResetUHostInstancePassword";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ResetUHostInstancePassword
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
        /// UHost实例ID                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// UHost新密码
        /// </summary>
        private string _password;

        /// <summary>
        /// UHost新密码               
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { _password = value.ToBase64(); }
        }

        /// <summary>
        /// 实例化 <see cref="ResetUHostInstancePasswordRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        public ResetUHostInstancePasswordRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
