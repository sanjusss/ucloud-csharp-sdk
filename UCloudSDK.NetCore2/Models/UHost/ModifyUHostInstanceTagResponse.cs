namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改指定UHost实例业务组标识。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/modify_uhost_instance_tag.html
    ///     </para>
    /// </summary>
    public partial class ModifyUHostInstanceTagResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ModifyUHostInstanceTagResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

    }
}
