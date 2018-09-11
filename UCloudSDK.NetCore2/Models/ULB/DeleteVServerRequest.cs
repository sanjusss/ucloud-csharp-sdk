namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除VServer实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/delete_vserver.html
    ///     </para>
    /// </summary>
    public partial class DeleteVServerRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DeleteVServer";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DeleteVServer
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
        /// VServer实例的ID                
        /// </summary>
        public string VServerId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DeleteVServerRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="ulbid">负载均衡实例的ID</param>                    
        /// <param name="vserverid">VServer实例的ID</param>                    
        public DeleteVServerRequest(string region, string ulbid, string vserverid)
        {               
            Region = region;
            ULBId = ulbid;
            VServerId = vserverid;
        }                
    }
}
