using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 指定数据中心，根据资源使用量创建指定数量的UHost实例。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/create_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class CreateUHostInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreateUHostInstanceResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost 实例 Id                
        /// </summary>
        public List<string> UHostIds { get; set; }

    }
}
