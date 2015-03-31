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
        /// API名称
        ///     <para>
        ///     UpdateULBAttribute
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "UpdateULBAttribute";
            }
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
        /// 负载均衡的名字 
        ///     <para>
        ///     若无此字段则不做修改
        ///     </para>                 
        /// </summary>
        public string ULBName { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdateULBAttributeRequest"/> 类.
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
