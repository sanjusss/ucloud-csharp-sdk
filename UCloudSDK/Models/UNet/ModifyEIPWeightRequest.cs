namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改弹性IP的外网出口权重
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/modify_eip_weight.html
    ///     </para>
    /// </summary>
    public partial class ModifyEIPWeightRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ModifyEIPWeight";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ModifyEIPWeight
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
        /// 弹性IP的资源ID                
        /// </summary>
        public string EIPId { get; set; }

        /// <summary>
        /// 外网出口权重 
        ///     <para>
        ///     范围[0-100]
        ///     </para>                 
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 实例化 <see cref="ModifyEIPWeightRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="eipid">弹性IP的资源ID</param>                    
        /// <param name="weight">外网出口权重</param>                    
        public ModifyEIPWeightRequest(string region, string eipid, int weight)
        {               
            Region = region;
            EIPId = eipid;
            Weight = weight;
        }                
    }
}
