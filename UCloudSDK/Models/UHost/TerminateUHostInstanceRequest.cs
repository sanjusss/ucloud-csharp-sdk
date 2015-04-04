namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除指定数据中心的UHost实例。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/terminate_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class TerminateUHostInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "TerminateUHostInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     TerminateUHostInstance
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
        /// UHost资源Id                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// 实例化 <see cref="TerminateUHostInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost资源Id</param>                    
        public TerminateUHostInstanceRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
