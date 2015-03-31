namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除VServer实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/delete_vserver.html
    ///     </para>
    /// </summary>
    public partial class DeleteVServerResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DeleteVServerResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
