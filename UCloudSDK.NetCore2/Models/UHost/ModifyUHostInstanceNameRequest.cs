namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改指定UHost实例名称，需要给出数据中心，UHostId，及新的实例名称。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/modify_uhost_instance_name.html
    ///     </para>
    /// </summary>
    public partial class ModifyUHostInstanceNameRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ModifyUHostInstanceName";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ModifyUHostInstanceName
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
        /// UHost实例名称                
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 实例化 <see cref="ModifyUHostInstanceNameRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        /// <param name="name">UHost实例名称</param>                    
        public ModifyUHostInstanceNameRequest(string region, string uhostid, string name)
        {               
            Region = region;
            UHostId = uhostid;
            Name = name;
        }                
    }
}
