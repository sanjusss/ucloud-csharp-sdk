namespace UCloudSDK.Models
{
    /// <summary>
    /// 根据提供信息，分配弹性IP
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/allocate_eip.html
    ///     </para>
    /// </summary>
    public partial class AllocateEIPAddr
    {
        /// <summary>
        /// 运营商信息                
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// IP地址                
        /// </summary>
        public string IP { get; set; }

    }
}
