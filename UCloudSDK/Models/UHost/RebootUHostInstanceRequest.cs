namespace UCloudSDK.Models
{
    /// <summary>
    /// 重新启动UHost实例，需要指定数据中心及UHostID两个参数的值。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/reboot_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class RebootUHostInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "RebootUHostInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     RebootUHostInstance
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
        /// 实例化 <see cref="RebootUHostInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        public RebootUHostInstanceRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
