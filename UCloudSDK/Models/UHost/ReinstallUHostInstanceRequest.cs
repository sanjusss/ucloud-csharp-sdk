namespace UCloudSDK.Models
{
    /// <summary>
    /// 重新安装指定UHost实例的操作系统
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/reinstall_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class ReinstallUHostInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ReinstallUHostInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ReinstallUHostInstance
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
        /// UHost实例资源ID                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// 如果创建UHost实例时LoginMode为Password
        /// </summary>
        private string _password;

        /// <summary>
        /// 如果创建UHost实例时LoginMode为Password 
        ///     <para>
        ///     则必须填写，如果LoginMode为KeyPair，不需要填写（密码格式使用BASE64编码）
        ///     </para>                 
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { _password = value.ToBase64(); }
        }

        /// <summary>
        /// 镜像Id 
        ///     <para>
        ///     参考镜像列表，默认使用原镜像
        ///     </para>                 
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 是否保留数据盘 
        ///     <para>
        ///     保留：Yes，不报留：No， 默认：Yes
        ///     </para>                 
        /// </summary>
        public string ReserveDisk { get; set; }

        /// <summary>
        /// 实例化 <see cref="ReinstallUHostInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例资源ID</param>                    
        public ReinstallUHostInstanceRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
