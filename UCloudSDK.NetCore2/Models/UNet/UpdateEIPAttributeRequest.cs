namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改EIP名字业务组备注等属性字段
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/update_eip_attribute.html
    ///     </para>
    /// </summary>
    public partial class UpdateEIPAttributeRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UpdateEIPAttribute";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UpdateEIPAttribute
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
        /// EIP资源ID                
        /// </summary>
        public string EIPId { get; set; }

        /// <summary>
        /// 名字 
        ///     <para>
        ///     Name Tag Remark都为空则报错
        ///     </para>                 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 弹性IP的业务组标识    
        ///     <para>
        ///     Name Tag Remark都为空则报错
        ///     </para>            
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 弹性IP的备注信息 
        ///     <para>
        ///     Name Tag Remark都为空则报错
        ///     </para>          
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdateEIPAttributeRequest"/> 类. 
        /// <para>必需设置Name Tag Remark中的一个</para>
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="eipid">EIP资源ID</param>                    
        public UpdateEIPAttributeRequest(string region, string eipid)
        {               
            Region = region;
            EIPId = eipid;
        }                
    }
}
