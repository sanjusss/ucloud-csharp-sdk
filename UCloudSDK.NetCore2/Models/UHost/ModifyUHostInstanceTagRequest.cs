namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改指定UHost实例业务组标识。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/modify_uhost_instance_tag.html
    ///     </para>
    /// </summary>
    public partial class ModifyUHostInstanceTagRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ModifyUHostInstanceTag";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ModifyUHostInstanceTag
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
        /// 业务组名称                
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 实例化 <see cref="ModifyUHostInstanceTagRequest" /> 类.
        /// </summary>
        /// <param name="region">数据中心</param>
        /// <param name="uhostid">UHost实例ID</param>
        /// <param name="tag">业务组名称.</param>
        public ModifyUHostInstanceTagRequest(string region, string uhostid, string tag)
        {
            Region = region;
            UHostId = uhostid;
            Tag = tag;
        }
    }
}
