namespace UCloudSDK.Models
{
    /// <summary>
    /// 释放ULB后端资源实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/release_backend.html
    ///     </para>
    /// </summary>
    public partial class ReleaseBackendRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ReleaseBackend";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ReleaseBackend
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        } 
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 负载均衡实例的ID                
        /// </summary>
        public string ULBId { get; set; }

        /// <summary>
        /// 后端资源实例的ID(ULB后端ID 
        ///     <para>
        ///     非资源自身ID)
        ///     </para>                 
        /// </summary>
        public string BackendId { get; set; }

        /// <summary>
        /// 实例化 <see cref="ReleaseBackendRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="ulbid">负载均衡实例的ID</param>                    
        /// <param name="backendid">后端资源实例的ID(ULB后端ID</param>                    
        public ReleaseBackendRequest(string region, string ulbid, string backendid)
        {               
            Region = region;
            ULBId = ulbid;
            BackendId = backendid;
        }                
    }
}
