using System;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 认证方式
    /// </summary>
    public enum LoginMode
    {
        /// <summary>
        /// 密码
        ///     <para>
        ///     使用密码时，密码必需进行base64编码
        ///     <c>string.ToBase64()</c>
        ///     </para>
        /// </summary>
        Password,
        /// <summary>
        /// key
        /// </summary>
        [Obsolete("暂不支持,请使用Password",true)]
        KeyPair
    }

    /// <summary>
    /// 计费模式，默认为月付
    /// </summary>
    public enum UHostChargeType
    {
        /// <summary>
        /// 按年付费
        /// </summary>
        Year,

        /// <summary>
        /// 按月付费
        /// </summary>
        Month,

        /// <summary>
        /// 按需付费（需开启权限）
        /// </summary>
        Dynamic,

        /// <summary>
        /// 试用（需开启权限）
        /// </summary>
        Trial
    }

    /// <summary>
    /// 数据中心列表
    ///     <para>
    ///     使用方法：<c>Region.cn_north_01.ToString().ToHyphen()</c>
    ///     </para>
    /// </summary>
    public enum Region
    {
        /// <summary>
        /// 北京BGP-A
        ///     <para>
        ///     Bgp: BGP线路
        ///     </para>
        /// </summary>
        cn_north_01,

        /// <summary>
        /// 北京BGP-B
        ///     <para>
        ///     Bgp: BGP线路
        ///     </para>
        /// </summary>
        cn_north_02,

        /// <summary>
        /// 北京BGP-C
        ///     <para>
        ///     Bgp: BGP线路
        ///     </para>
        /// </summary>
        cn_north_03,

        /// <summary>
        /// 华东双线
        ///     <para>
        ///     Duplet: 双线, Unicom: 网通, Telecom: 电信
        ///     </para>
        /// </summary>
        cn_east_01,

        /// <summary>
        /// 华南双线
        ///     <para>
        ///     Duplet: 双线, Unicom: 网通, Telecom: 电信
        ///     </para>
        /// </summary>
        cn_south_01,

        /// <summary>
        /// 亚太
        ///     <para>
        ///     International: 国际线路
        ///     </para>
        /// </summary>
        hk_01,

        /// <summary>
        /// 北美
        ///     <para>
        ///     International: 国际线路
        ///     </para>
        /// </summary>
        us_west_01
    }

    /// <summary>
    /// 镜像类型
    /// </summary>
    public enum ImageType
    {
        /// <summary>
        /// 标准镜像
        /// </summary>
        Base,

        /// <summary>
        /// 行业镜像
        /// </summary>
        Business,

        /// <summary>
        /// 自定义镜像
        /// </summary>
        Custom
    }

    /// <summary>
    /// 操作系统类型
    /// </summary>
    public enum OsType
    {
        /// <summary>
        /// The linux
        /// </summary>
        Linux,
        /// <summary>
        /// The windows
        /// </summary>
        Windows
    }

    /// <summary>
    /// 弹性IP的线路
    /// </summary>
    public enum OperatorName
    {
        /// <summary>
        /// 电信
        /// </summary>
        Telecom,

        /// <summary>
        /// 联通
        /// </summary>
        Unicom,

        /// <summary>
        /// 国际:
        /// </summary>
        International,

        /// <summary>
        /// BGP
        /// </summary>
        Bgp,

        /// <summary>
        /// 双线
        /// </summary>
        Duplet
    }

    /// <summary>
    /// 弹性IP请求绑定的资源类型
    /// </summary>
    public enum ResourceType
    {
        /// <summary>
        /// 云主机
        /// </summary>
        uhost,

        /// <summary>
        /// 虚拟路由器
        /// </summary>
        vrouter,

        /// <summary>
        /// 负载均衡器
        /// </summary>
        ulb
    }

    /// <summary>
    /// 刷新类型
    /// </summary>
    public enum CDNRefreshType
    {
        /// <summary>
        /// 文件刷新
        /// </summary>
        file,
        /// <summary>
        /// 路径刷新
        /// </summary>
        dir
    }

    /// <summary>
    /// 网络协议
    /// </summary>
    public enum Proto
    {
        /// <summary>
        /// The TCP
        /// </summary>
        TCP,
        /// <summary>
        /// The UDP
        /// </summary>
        UDP,
        /// <summary>
        /// The icmp
        /// </summary>
        ICMP,
        /// <summary>
        /// The gre
        /// </summary>
        GRE
    }

    /// <summary>
    /// 规则优先级
    ///     <para>
    ///     使用方法：<c>((int)Priority.High).ToString()</c>
    ///     </para>
    /// </summary>
    public enum Priority
    {
        /// <summary>
        /// 高
        /// </summary>
        High = 50,
        /// <summary>
        /// 中
        /// </summary>
        Medium = 100,
        /// <summary>
        /// 低
        /// </summary>
        Low = 150
    }

    /// <summary>
    /// VServer实例的协议
    /// </summary>
    public enum Protocol
    {
        /// <summary>
        /// The HTTP
        /// </summary>
        HTTP,
        /// <summary>
        /// The TCP
        /// </summary>
        TCP,
        /// <summary>
        /// The UDP
        /// </summary>
        UDP
    }

    /// <summary>
    /// VServer负载均衡模式
    /// </summary>
    public enum VServerMethod
    {
        /// <summary>
        /// 轮询
        ///     <para>
        ///     默认
        ///     </para>
        /// </summary>
        Roundrobin,

        /// <summary>
        /// 源地址
        /// </summary>
        Source
    }

    /// <summary>
    /// VServer会话保持方式
    /// </summary>
    public enum PersistenceType
    {
        /// <summary>
        ///  关闭会话保持
        ///     <para>
        ///     默认
        ///     </para>
        /// </summary>
        None,

        /// <summary>
        /// 自动生成； 
        /// </summary>
        ServerInsert,

        /// <summary>
        /// 用户自定义
        /// </summary>
        UserDefined
    }

    /// <summary>
    /// 后端实例状态开关
    /// </summary>
    public enum BackendEnabled
    {
        /// <summary>
        /// 禁用
        /// </summary>
        False = 0,
        /// <summary>
        /// 启用
        ///     <para>
        ///     默认
        ///     </para>
        /// </summary>
        True = 1
    }

    /// <summary>
    /// 购买流量的区域
    /// </summary>
    public enum Areacode
    {
        /// <summary>
        /// 国内
        /// </summary>
        cn,

        /// <summary>
        /// The abroad海外
        /// </summary>
        abroad
    }

    /// <summary>
    /// UCDN计费方式
    /// <para>目前仅支持按流量包计费</para>
    /// </summary>
    public enum UcdnChargeType
    {
        /// <summary>
        /// 按流量包计费
        /// </summary>
        traffic,
        /// <summary>
        /// 按带宽计费
        /// </summary>
        bandwidth,
        /// <summary>
        /// 流量后付费
        /// </summary>
        trafficused
    }

    /// <summary>
    /// 加速域名的业务类型
    /// </summary>
    public enum CdnType
    {
        /// <summary>
        /// 网站
        /// </summary>
        web,
        /// <summary>
        /// 视频
        /// </summary>
        stream,
        /// <summary>
        /// 下载
        /// </summary>
        download,
        /// <summary>
        /// 直播
        /// </summary>
        Live
    }

    /// <summary>
    /// 直播类型
    /// </summary>
    public enum LiveSrcType
    {
        /// <summary>
        /// The rtmppush
        /// </summary>
        rtmppush,
        /// <summary>
        /// The rtmppull
        /// </summary>
        rtmppull,
        /// <summary>
        /// The HLS
        /// </summary>
        hls
    }

    /// <summary>
    /// 需要获取的内容刷新的状态
    /// </summary>
    public enum CacheTaskStatus
    {
        /// <summary>
        /// 成功
        /// </summary>
        success,

        /// <summary>
        /// 等待处理
        /// </summary>
        wait,

        /// <summary>
        /// 正在处理
        /// </summary>
        process,
        /// <summary>
        /// 失败
        /// </summary>
        failure,

        /// <summary>
        /// 未知
        /// </summary>
        unkonw
    }

    /// <summary>
    /// 域名状态
    /// </summary>
    public enum UcdnDomainStatus
    {
        /// <summary>
        /// 加速中
        /// </summary>
        enable,
        /// <summary>
        /// 停止加速
        /// </summary>
        disable,
        /// <summary>
        /// 删除加速
        /// <para>目前仅支持删除审核失败的域名</para>
        /// </summary>
        delete
    }

    /// <summary>
    /// 云主机监控指标名称
    /// </summary>
    public enum UHostMetric
    {
        /// <summary>
        /// The network in
        /// </summary>
        NetworkIn,
        /// <summary>
        /// The network out
        /// </summary>
        NetworkOut,
        /// <summary>
        /// The cpu utilization
        /// </summary>
        CPUUtilization,
        /// <summary>
        /// The io read
        /// </summary>
        IORead,
        /// <summary>
        /// The io write
        /// </summary>
        IOWrite,
        /// <summary>
        /// The disk read ops
        /// </summary>
        DiskReadOps,
        /// <summary>
        /// The nic in
        /// </summary>
        NICIn,
        /// <summary>
        /// The nic out
        /// </summary>
        NICOut,
        /// <summary>
        /// The memory usage
        /// </summary>
        MemUsage,
        /// <summary>
        /// The data space usage
        /// </summary>
        DataSpaceUsage,
        /// <summary>
        /// The root space usage
        /// </summary>
        RootSpaceUsage,
        /// <summary>
        /// The readonly disk count
        /// </summary>
        ReadonlyDiskCount,
        /// <summary>
        /// The runnable process count
        /// </summary>
        RunnableProcessCount,
        /// <summary>
        /// The block process count
        /// </summary>
        BlockProcessCount
    }

    /// <summary>
    /// 云数据库监控指标名称
    /// </summary>
    public enum UdbMetric
    {
        /// <summary>
        /// The cpu utilization
        /// </summary>
        CPUUtilization,
        /// <summary>
        /// The memory usage
        /// </summary>
        MemUsage,
        /// <summary>
        /// The QPS
        /// </summary>
        QPS,
        /// <summary>
        /// The expensive query
        /// </summary>
        ExpensiveQuery
    }

    /// <summary>
    /// 负载均衡监控指标名称
    /// </summary>
    public enum UlbMetric
    {
        /// <summary>
        /// The network out
        /// </summary>
        NetworkOut,
        /// <summary>
        /// The total network out
        /// </summary>
        TotalNetworkOut,
        /// <summary>
        /// The current connections
        /// </summary>
        CurrentConnections
    }

    /// <summary>
    /// 云内存存储监控指标名称
    /// </summary>
    public enum UmemMetric
    {
        /// <summary>
        /// The usage
        /// </summary>
        Usage,
        /// <summary>
        /// The QPS
        /// </summary>
        QPS,
        /// <summary>
        /// The instance count
        /// </summary>
        InstanceCount
    }

    /// <summary>
    /// 监控数据的资源类型
    /// </summary>
    public enum MetricResourceType
    {
        /// <summary>
        /// 云主机
        /// </summary>
        uhost,

        /// <summary>
        /// 云数据库
        /// </summary>
        udb,

        /// <summary>
        /// 负载均衡器
        /// </summary>
        ulb,

        /// <summary>
        /// 云内存存储
        /// </summary>
        umem
    }

    /// <summary>
    /// 防火墙动作
    /// </summary>
    public enum RuleAction
    {
        /// <summary>
        /// 允许通过防火墙
        /// </summary>
        ACCEPT,
        /// <summary>
        /// 禁止通过防火墙并不给任何返回信息
        /// </summary>
        DROP
    }

    /// <summary>
    /// 日志类型
    /// </summary>
    public enum UDBLogType
    {
        /// <summary>
        /// The error
        /// </summary>
        [Obsolete("暂不支持,请使用binlog", true)]
        error=10,
        /// <summary>
        /// The slow
        /// </summary>
        [Obsolete("暂不支持,请使用binlog", true)]
        slow=20,
        /// <summary>
        /// The binlog
        /// </summary>
        binlog=30
    }

    /// <summary>
    /// DB种类
    /// </summary>
    public enum UDBClassType
    {
        /// <summary>
        /// The SQL
        /// </summary>
        SQL,
        /// <summary>
        /// The nosql
        /// </summary>
        NOSQL
    }
}