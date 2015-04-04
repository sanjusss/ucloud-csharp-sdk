namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取指定UHost实例的管理VNC配置详细信息。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/get_uhost_instance_vnc_info.html
    ///     </para>
    /// </summary>
    public partial class GetUHostInstanceVncInfoRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "GetUHostInstanceVncInfo";

        /// <summary>
        /// API名称
        ///     <para>
        ///     GetUHostInstanceVncInfo
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
        /// 实例化 <see cref="GetUHostInstanceVncInfoRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        public GetUHostInstanceVncInfoRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
