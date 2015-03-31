namespace UCloudSDK.Models
{
    /// <summary>
    /// 导入udb配置
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/upload_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class UploadUDBParamGroupResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 配置参数组id                
        /// </summary>
        public int GroupId { get; set; }

    }
}
