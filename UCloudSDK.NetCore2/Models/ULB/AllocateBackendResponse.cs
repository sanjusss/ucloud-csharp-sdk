namespace UCloudSDK.Models
{
    /// <summary>
    /// 添加ULB后端资源实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/allocate_backend.html
    ///     </para>
    /// </summary>
    public partial class AllocateBackendResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     AllocateBackendResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 所添加的后端资源ID 
        ///     <para>
        ///     （为ULB系统中使用，与资源自身ID无关）
        ///     </para>                 
        /// </summary>
        public string BackendId { get; set; }

    }
}
