namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示负载均衡实例信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_ulb.html
    ///     </para>
    /// </summary>
    public partial class DescribeULBBackendSet
    {
        /// <summary>
        /// VServer后端的负载均衡实例ID                
        /// </summary>
        public string BackendId { get; set; }

        /// <summary>
        /// VServer后端的资源类型 
        ///     <para>
        ///     如uhost
        ///     </para>                 
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// VServer后端的资源ID                
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// VServer后端的资源名称                
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// VServer后端的资源内网IP                
        /// </summary>
        public string PrivateIP { get; set; }

        /// <summary>
        /// VServer后端的服务端口                
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 后端资源的启用状态 
        ///     <para>
        ///     枚举值为：0：禁用；1：启用
        ///     </para>                 
        /// </summary>
        public int Enabled { get; set; }

        /// <summary>
        /// 后端资源的运行状态 
        ///     <para>
        ///     枚举值为：0：运行正常；1：运行异常
        ///     </para>                 
        /// </summary>
        public int Status { get; set; }

    }
}
