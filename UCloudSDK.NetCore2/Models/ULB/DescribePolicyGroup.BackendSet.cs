namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示内容转发策略组详情
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_policy_group.html
    ///     </para>
    /// </summary>
    public partial class DescribePolicyGroupBackendSet
    {
        /// <summary>
        /// 后端资源实例的ID                
        /// </summary>
        public string BackendId { get; set; }

        /// <summary>
        /// 后端资源实例的内网IP                
        /// </summary>
        public string PrivateIP { get; set; }

        /// <summary>
        /// 后端资源实例的服务端口                
        /// </summary>
        public int Port { get; set; }

    }
}
