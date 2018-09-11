using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除指定数据中心的UHost实例。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/terminate_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class TerminateUHostInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     TerminateUHostInstanceResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost 实例 Id                
        /// </summary>
        public List<string> UHostIds { get; set; }

    }
}
