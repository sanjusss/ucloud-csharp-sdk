using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取加速域名详细信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/describe_ucdn_domain.html
    ///     </para>
    /// </summary>
    public partial class DescribeUcdnDomainSet
    {
        /// <summary>
        /// 加速域名                
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// 加速域名ID 
        ///     <para>
        ///     创建加速域名时生成
        ///     </para>                 
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// 源站IP 
        ///     <para>
        ///     即cdn服务器回源访问的IP地址。多个IP地址可以表述为：[“1.1.1.1”, “2.2.2.2”]
        ///     </para>                 
        /// </summary>
        public List<string> SourceIp { get; set; }

        /// <summary>
        /// 加速域名的业务类型 
        ///     <para>
        ///     枚举值：web：网站；Stream：视频；download：下载；live：直播
        ///     </para>                 
        /// </summary>
        public string CdnType { get; set; }

        /// <summary>
        /// 计费方式 
        ///     <para>
        ///     枚举值为：traffic：按流量包计费；bandwidth：按带宽付费；trafficused：流量后付费（目前仅支持流量包计费）
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 加速域名的当前状态 
        ///     <para>
        ///     check：审核中；checkSuccess：审核通过；checkFaile：审核失败；enable(ing)：(正在)加速中；disable(ing)：(正在)停止加速；delete(ing)：(正在)删除加速
        ///     </para>                 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// cdn域名 
        ///     <para>
        ///     创建加速域名时生成的cdn域名，用于设置CNAME记录
        ///     </para>                 
        /// </summary>
        public string Cname { get; set; }

        /// <summary>
        /// 域名创建的时间 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public string CreateTime { get; set; }

        /// <summary>
        /// 开始分配Cname时间 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public string VaildTime { get; set; }

        /// <summary>
        /// 测试URL 
        ///     <para>
        ///     用于测试加速域名
        ///     </para>                 
        /// </summary>
        public string TestUrl { get; set; }

        /// <summary>
        /// CDN加速区域 
        ///     <para>
        ///     cn：国内；abroad：国外。[ “cn”, “abroad” ]表示两者皆启用
        ///     </para>                 
        /// </summary>
        public List<string> Areaode { get; set; }

        /// <summary>
        /// 缓存文件类型 
        ///     <para>
        ///     多个文件表述为: [“zip”, “txt”]
        ///     </para>                 
        /// </summary>
        public List<string> CacheFileType { get; set; }

        /// <summary>
        /// 需要缓存的文件或者路径 
        ///     <para>
        ///     多个文件表述为：[ “http://Domain/*.jpg”, “http://Domain/*.png” ]
        ///     </para>                 
        /// </summary>
        public List<string> CacheUrl { get; set; }

        /// <summary>
        /// 缓存文件生命周期 
        ///     <para>
        ///     单位秒
        ///     </para>                 
        /// </summary>
        public int CacheTtl { get; set; }

        /// <summary>
        /// 不需要缓存的文件 
        ///     <para>
        ///     格式同CacheUrl
        ///     </para>                 
        /// </summary>
        public List<string> NoCacheUrl { get; set; }

        /// <summary>
        /// 直播流数                
        /// </summary>
        public int LiveStreamCount { get; set; }

        /// <summary>
        /// 直播接入类型 
        ///     <para>
        ///     rtmppush/rtmppull/hls
        ///     </para>                 
        /// </summary>
        public string LiveSrcType { get; set; }

        /// <summary>
        /// 拉去流url                
        /// </summary>
        public string LiveSrcUrl { get; set; }

        /// <summary>
        /// 直播流ID                
        /// </summary>
        public string LiveStreamIds { get; set; }

        /// <summary>
        /// 流程申请失败原因                
        /// </summary>
        public string ApplyMessage { get; set; }

    }
}
