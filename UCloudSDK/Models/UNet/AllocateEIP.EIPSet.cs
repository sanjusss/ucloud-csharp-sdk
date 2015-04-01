using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 根据提供信息，分配弹性IP
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/allocate_eip.html
    ///     </para>
    /// </summary>
    public partial class AllocateEIPSet
    {
        /// <summary>
        /// 申请到的EIP资源ID                
        /// </summary>
        public string EIPId { get; set; }

        /// <summary>
        /// 申请到的IPv4地址 
        ///     <para>
        ///     双线拥有两个IP地址）
        ///     </para>                 
        /// </summary>
        public List<AllocateEIPAddr> EIPAddr { get; set; }

    }
}
