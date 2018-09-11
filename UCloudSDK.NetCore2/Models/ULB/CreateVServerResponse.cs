namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建VServer实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/create_vserver.html
    ///     </para>
    /// </summary>
    public partial class CreateVServerResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreateULBResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// VServer实例的Id                
        /// </summary>
        public string VServerId { get; set; }

    }
}
