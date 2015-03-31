namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除配置参数组
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/delete_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class DeleteUDBParamGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
