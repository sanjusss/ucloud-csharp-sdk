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
        /// API名称
        ///     <para>
        ///     ResetUHostInstancePassword
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "ResetUHostInstancePassword";
            }
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
        ///     <para>
        ///     密码格式使用BASE64编码）
        ///     </para>                 
        /// </summary>
        public string Password { get; set; }

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
