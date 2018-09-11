namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改VServer实例属性
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/update_vserver_attribute.html
    ///     </para>
    /// </summary>
    public partial class UpdateVServerAttributeRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UpdateVServerAttribute";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UpdateVServerAttribute
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
        /// 负载均衡实例ID                
        /// </summary>
        public string ULBId { get; set; }

        /// <summary>
        /// VServer实例ID                
        /// </summary>
        public string VServerId { get; set; }

        /// <summary>
        /// VServer实例名称 
        ///     <para>
        ///     若无此字段则不做修改
        ///     </para>                 
        /// </summary>
        public string VServerName { get; set; }

        /// <summary>
        /// VServer协议 
        ///     <para>
        ///     枚举值为: HTTP, TCP, UDP. 若无此字段则不做修改
        ///     </para>                 
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// VServer负载均衡算法 
        ///     <para>
        ///      枚举值为: Roundrobin, 轮询模式; Source,源IP模式. 若无此字段则不做修改
        ///     </para>                 
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// VServer会话保持模式 
        ///     <para>
        ///      枚举值为:None, 关闭会话保持;ServerInsert, 自动生成;UserDefined, 用户自定义.若无此字段则不做修改
        ///     </para>                 
        /// </summary>
        public string PersistenceType { get; set; }

        /// <summary>
        /// 根据PersistenceType确定 
        ///     <para>
        ///     None或ServerInsert, 此字段无意义;UserDefined, 则此字段传入用户自定义会话保持String.若无此字段则不做修改
        ///     </para>                 
        /// </summary>
        public string PersistenceInfo { get; set; }

        /// <summary>
        /// 空闲连接的回收时间 
        ///     <para>
        ///      单位: 秒.取值范围: (0, 86400], 默认值: 60秒.若无此字段,则不做修改
        ///     </para>                 
        /// </summary>
        public string ClientTimeout { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdateVServerAttributeRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="ulbid">负载均衡实例ID</param>                    
        /// <param name="vserverid">VServer实例ID</param>                           
        public UpdateVServerAttributeRequest(string region, string ulbid, string vserverid)
        {
            Region = region;
            ULBId = ulbid;
            VServerId = vserverid;
        }

        /// <summary>
        /// 实例化 <see cref="UpdateVServerAttributeRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="ulbid">负载均衡实例ID</param>                    
        /// <param name="vserverid">VServer实例ID</param>                    
        /// <param name="vservername">VServer实例名称</param>                    
        /// <param name="protocol">VServer协议</param>                    
        /// <param name="method">VServer负载均衡算法</param>                    
        /// <param name="persistencetype">VServer会话保持模式</param>                    
        /// <param name="persistenceinfo">根据PersistenceType确定</param>                    
        /// <param name="clienttimeout">空闲连接的回收时间</param>                    
        public UpdateVServerAttributeRequest(string region, string ulbid, string vserverid, string vservername, string protocol, string method, string persistencetype, string persistenceinfo, string clienttimeout)
        {               
            Region = region;
            ULBId = ulbid;
            VServerId = vserverid;
            VServerName = vservername;
            Protocol = protocol;
            Method = method;
            PersistenceType = persistencetype;
            PersistenceInfo = persistenceinfo;
            ClientTimeout = clienttimeout;
        }                
    }
}
