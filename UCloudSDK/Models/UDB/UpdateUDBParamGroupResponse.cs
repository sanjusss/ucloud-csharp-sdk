namespace UCloudSDK.Models
{
    /// <summary>
    /// 更新udb配置参数项
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/update_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class UpdateUDBParamGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

    }
}
