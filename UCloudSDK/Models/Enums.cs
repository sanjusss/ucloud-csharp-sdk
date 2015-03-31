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
        Linux,
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
    /// 网络协议
    /// </summary>
    public enum Proto
    {
        TCP,
        UDP,
        ICMP,
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
        High = 0,
        /// <summary>
        /// 中
        /// </summary>
        Medium = 50,
        /// <summary>
        /// 低
        /// </summary>
        Low = 100
    }

    /// <summary>
    /// VServer实例的协议
    /// </summary>
    public enum Protocol
    {
        HTTP,
        TCP,
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
    /// 直播类型
    /// </summary>
    public enum LiveSrcType
    {
        rtmppush,
        rtmppull,
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
    public enum DomainStatus
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
        /// </summary>
        delete
    }

    /// <summary>
    /// 云主机监控指标名称
    /// </summary>
    public enum UHostMetric
    {
        NetworkIn,
        NetworkOut,
        CPUUtilization,
        IORead,
        IOWrite,
        DiskReadOps,
        NICIn,
        NICOut,
        MemUsage,
        DataSpaceUsage,
        RootSpaceUsage,
        ReadonlyDiskCount,
        RunnableProcessCount,
        BlockProcessCount
    }

    /// <summary>
    /// 云数据库监控指标名称
    /// </summary>
    public enum UdbMetric
    {
        CPUUtilization,
        MemUsage,
        QPS,
        ExpensiveQuery
    }

    /// <summary>
    /// 负载均衡监控指标名称
    /// </summary>
    public enum UlbMetric
    {
        NetworkOut,
        TotalNetworkOut,
        CurrentConnections
    }

    /// <summary>
    /// 云内存存储监控指标名称
    /// </summary>
    public enum UmemMetric
    {
        Usage,
        QPS,
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
}