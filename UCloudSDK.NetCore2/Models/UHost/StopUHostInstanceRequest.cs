namespace UCloudSDK.Models
{
    /// <summary>
    /// 指停止处于运行状态的UHost实例，需指定数据中心及UhostID。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/stop_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class StopUHostInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "StopUHostInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     StopUHostInstance
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
        /// 实例化 <see cref="StopUHostInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        public StopUHostInstanceRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
