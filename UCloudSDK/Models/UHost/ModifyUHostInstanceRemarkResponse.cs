namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改指定UHost实例备注信息。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/modify_uhost_instance_remark.html
    ///     </para>
    /// </summary>
    public partial class ModifyUHostInstanceRemarkResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ModifyUHostInstanceRemarkResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

    }
}
