using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 根据提供信息，分配内网VIP(Virtual IP，多用于高可用程序作为漂移IP。)
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/allocate_vip.html
    ///     </para>
    /// </summary>
    public partial class AllocateVIPResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     AllocateVIPResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 申请到的VIP资源地址                
        /// </summary>
        public List<string> DataSet { get; set; }

    }
}
