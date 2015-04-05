namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改负载均衡实例属性
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/update_ulb_attribute.html
    ///     </para>
    /// </summary>
    public partial class UpdateULBAttributeRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UpdateULBAttribute";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UpdateULBAttribute
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
        /// 名字 
        ///     <para>
        ///     Name Tag Remark都为空则报错
        ///     </para>                 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 业务 
        ///     <para>
        ///     Name Tag Remark都为空则报错
        ///     </para>                 
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 备注 
        ///     <para>
        ///     Name Tag Remark都为空则报错
        ///     </para>                 
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdateULBAttributeRequest"/> 类.
        /// <para>实例化后需要指定Name Tag Remark中的一个</para>
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="ulbid">负载均衡实例ID</param>                    
        public UpdateULBAttributeRequest(string region, string ulbid)
        {               
            Region = region;
            ULBId = ulbid;
        }                
    }
}
