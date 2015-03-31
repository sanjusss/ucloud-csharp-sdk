namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改弹性IP的外网带宽
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/modify_eip_bandwidth.html
    ///     </para>
    /// </summary>
    public partial class ModifyEIPBandwidthResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     ModifyEIPBandwidthResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

    }
}
