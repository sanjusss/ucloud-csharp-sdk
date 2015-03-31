namespace UCloudSDK.Models
{
    /// <summary>
    /// 从已有配置文件创建新配置文件
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/create_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class CreateUDBParamGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 新配置参数组id                
        /// </summary>
        public int GroupId { get; set; }

    }
}
