namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除负载均衡实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/delete_ulb.html
    ///     </para>
    /// </summary>
    public partial class DeleteULBResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     DeleteULBResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
