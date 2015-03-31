namespace UCloudSDK.Models
{
    /// <summary>
    /// 释放ULB后端资源实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/release_backend.html
    ///     </para>
    /// </summary>
    public partial class ReleaseBackendResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ReleaseBackendResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
