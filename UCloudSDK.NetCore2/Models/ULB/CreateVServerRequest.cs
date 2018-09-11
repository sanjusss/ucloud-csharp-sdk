namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建VServer实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/create_vserver.html
    ///     </para>
    /// </summary>
    public partial class CreateVServerRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateVServer";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateVServer
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
        /// VServer实例名称 
        ///     <para>
        ///     默认为空
        ///     </para>                 
        /// </summary>
        public string VServerName { get; set; }

        /// <summary>
        /// VServer实例的协议 
        ///     <para>
        ///     枚举值为：HTTP，TCP，UDP；默认为HTTP协议
        ///     </para>                 
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// VServer后端端口 
        ///     <para>
        ///     取值范围[1-65535]；默认值为80
        ///     </para>                 
        /// </summary>
        public int? FrontendPort { get; set; }

        /// <summary>
        /// VServer负载均衡模式 
        ///     <para>
        ///     枚举值为：Roundrobin，轮询；Source，源地址；默认为轮询模式
        ///     </para>                 
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// VServer会话保持方式 
        ///     <para>
        ///     枚举值为：None，关闭会话保持；ServerInsert，自动生成；UserDefined，用户自定义；默认关闭会话保持。
        ///     </para>                 
        /// </summary>
        public string PersistenceType { get; set; }

        /// <summary>
        /// 根据PersistenceType确认；None和ServerInsert 
        ///     <para>
        ///     此字段无意义；UserDefined：此字段传入自定义会话保持String
        ///     </para>                 
        /// </summary>
        public string PersistenceInfo { get; set; }

        /// <summary>
        /// 空闲连接的回收时间 
        ///     <para>
        ///     单位：秒；取值范围：(0，86400]，默认值为60
        ///     </para>                 
        /// </summary>
        public int? ClientTimeout { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateVServerRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="ulbid">负载均衡实例ID</param>                    
        public CreateVServerRequest(string region, string ulbid)
        {               
            Region = region;
            ULBId = ulbid;
        }                
    }
}
