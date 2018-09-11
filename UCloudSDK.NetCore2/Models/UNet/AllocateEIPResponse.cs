using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 根据提供信息，分配弹性IP
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/allocate_eip.html
    ///     </para>
    /// </summary>
    public partial class AllocateEIPResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     AllocateEIPResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 申请到的EIP资源详情                
        /// </summary>
        public List<AllocateEIPSet> EIPSet { get; set; }

    }
}
