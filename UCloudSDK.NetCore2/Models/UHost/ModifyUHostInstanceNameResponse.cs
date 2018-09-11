namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改指定UHost实例名称，需要给出数据中心，UHostId，及新的实例名称。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/modify_uhost_instance_name.html
    ///     </para>
    /// </summary>
    public partial class ModifyUHostInstanceNameResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ModifyUHostInstanceNameResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

    }
}
