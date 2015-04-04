namespace UCloudSDK.Models
{
    /// <summary>
    /// 创建负载均衡实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/create_ulb.html
    ///     </para>
    /// </summary>
    public partial class CreateULBRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateULB";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateULB
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
        /// 负载均衡的名字 
        ///     <para>
        ///     默认值为空
        ///     </para>                 
        /// </summary>
        public string ULBName { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateULBRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public CreateULBRequest(string region)
        {               
            Region = region;
        }                
    }
}
