using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示负载均衡实例信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_ulb.html
    ///     </para>
    /// </summary>
    public partial class DescribeULBVserverSet
    {
        /// <summary>
        /// VServer实例的ID                
        /// </summary>
        public string VServerId { get; set; }

        /// <summary>
        /// VServer实例的名字                
        /// </summary>
        public string VServerName { get; set; }

        /// <summary>
        /// VServer实例的网络协议 
        ///     <para>
        ///     枚举值为：HTTP, TCP, UDP, HTTPS
        ///     </para>                 
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// VServer服务前端端口                
        /// </summary>
        public int FrontendPort { get; set; }

        /// <summary>
        /// VServer的负载均衡模式 
        ///     <para>
        ///     枚举值为：Roundrobin，轮询模式；Source，源地址模式
        ///     </para>                 
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// VServer会话保持模式 
        ///     <para>
        ///     枚举值为：None，关闭会话保持；ServerInsert，自动生成；UserDefined，用户自定义
        ///     </para>                 
        /// </summary>
        public string PersistenceType { get; set; }

        /// <summary>
        /// 由PersistenceType确定 
        ///     <para>
        ///     None或ServerInsert时，此字段为空；UserDefined时，此字段展示用户自定义会话保持String。
        ///     </para>                 
        /// </summary>
        public string PersistenceInfo { get; set; }

        /// <summary>
        /// 空闲连接的回收时间 
        ///     <para>
        ///     单位：秒
        ///     </para>                 
        /// </summary>
        public int ClientTimeout { get; set; }

        /// <summary>
        /// VServer的运行状态 
        ///     <para>
        ///     枚举值为：0：运行正常；1：运行异常
        ///     </para>                 
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// VServer绑定的SSL证书信息 
        ///     <para>
        ///     具体结构见下方SSLSet
        ///     </para>                 
        /// </summary>
        public List<DescribeULBSSLSet> SSLSet { get; set; }

        /// <summary>
        /// VServer后端资源信息列表 
        ///     <para>
        ///     具体结构见下方BackendSet
        ///     </para>                 
        /// </summary>
        public List<DescribeULBBackendSet> BackendSet { get; set; }

    }
}
