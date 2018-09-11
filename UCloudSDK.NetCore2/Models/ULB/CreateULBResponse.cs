namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建负载均衡实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/create_ulb.html
    ///     </para>
    /// </summary>
    public partial class CreateULBResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreateULBResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 负载均衡实例的Id                
        /// </summary>
        public string ULBId { get; set; }

    }
}
