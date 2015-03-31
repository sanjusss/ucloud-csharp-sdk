namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改弹性IP的外网出口权重
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/modify_eip_weight.html
    ///     </para>
    /// </summary>
    public partial class ModifyEIPWeightResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ModifyEIPWeightResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
