using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb实例信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBInstanceDataSet
    {
        /// <summary>
        /// DB实例id                
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 实例名称 
        ///     <para>
        ///     至少6位
        ///     </para>                 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// DB类型id 
        ///     <para>
        ///     mysql/mongodb按版本细分各有一个id1：mysql-5.5，2：mysql-5.1，3：percona-5.54：mongodb-2.4，5：mongodb-2.6，6：mysql-5.6，7：percona-5.6
        ///     </para>                 
        /// </summary>
        public string DBTypeId { get; set; }

        /// <summary>
        /// DB实例使用的配置参数组id                
        /// </summary>
        public int ParamGroupId { get; set; }

        /// <summary>
        /// 管理员帐户名 
        ///     <para>
        ///     默认root
        ///     </para>                 
        /// </summary>
        public string AdminUser { get; set; }

        /// <summary>
        /// DB实例虚ip                
        /// </summary>
        public string VirtualIP { get; set; }

        /// <summary>
        /// DB实例虚ip的mac地址                
        /// </summary>
        public string VirtualIPMac { get; set; }

        /// <summary>
        /// 端口号 
        ///     <para>
        ///     mysql默认3306，mongodb默认27017
        ///     </para>                 
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 对mysql的slave而言是master的DBId 
        ///     <para>
        ///     对master则为空，对mongodb则是副本集id
        ///     </para>                 
        /// </summary>
        public string SrcDBId { get; set; }

        /// <summary>
        /// 备份策略 
        ///     <para>
        ///     每周备份数量，默认7次
        ///     </para>                 
        /// </summary>
        public int BackupCount { get; set; }

        /// <summary>
        /// 备份策略 
        ///     <para>
        ///     备份开始时间，单位小时计，默认3点
        ///     </para>                 
        /// </summary>
        public int BackupBeginTime { get; set; }

        /// <summary>
        /// 备份策略 
        ///     <para>
        ///     备份时间间隔，单位小时计，默认24小时
        ///     </para>                 
        /// </summary>
        public int BackupDuration { get; set; }

        /// <summary>
        /// 备份策略 
        ///     <para>
        ///     备份黑名单，mongodb则不适用
        ///     </para>                 
        /// </summary>
        public string BackupBlacklist { get; set; }

        /// <summary>
        /// DB状态标记Init                           // 初始化中Fail                           // 安装失败Starting                       // 启动中Running                        // 运行Shutdown                       // 关闭中Shutoff                        // 已关闭Delete                         // 已删除Upgrading                      // 升级中Promoting                      // 提升为独库进行中Recovering                     // 恢复中Recover fail                   // 恢复失败                
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// DB实例创建时间 
        ///     <para>
        ///     采用UTC计时时间戳
        ///     </para>                 
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// DB实例修改时间 
        ///     <para>
        ///     采用UTC计时时间戳
        ///     </para>                 
        /// </summary>
        public int ModifyTime { get; set; }

        /// <summary>
        /// DB实例过期时间 
        ///     <para>
        ///     采用UTC计时时间戳
        ///     </para>                 
        /// </summary>
        public int ExpiredTime { get; set; }

        /// <summary>
        /// Year 
        ///     <para>
        ///      Month， Dynamic，Trial，默认: Dynamic
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 内存限制(MB) 
        ///     <para>
        ///     默认根据配置机型
        ///     </para>                 
        /// </summary>
        public int MemoryLimit { get; set; }

        /// <summary>
        /// 磁盘空间(GB) 
        ///     <para>
        ///      默认根据配置机型
        ///     </para>                 
        /// </summary>
        public int DiskSpace { get; set; }

        /// <summary>
        /// 是否使用SSD                
        /// </summary>
        public bool UseSSD { get; set; }

        /// <summary>
        /// DB实例角色 
        ///     <para>
        ///     mysql区分master/slave，mongodb多种角色
        ///     </para>                 
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// DB实例磁盘已使用空间 
        ///     <para>
        ///     单位GB
        ///     </para>                 
        /// </summary>
        public int DiskUsedSize { get; set; }

        /// <summary>
        /// DB实例数据文件大小 
        ///     <para>
        ///     单位GB
        ///     </para>                 
        /// </summary>
        public int DataFileSize { get; set; }

        /// <summary>
        /// DB实例系统文件大小 
        ///     <para>
        ///     单位GB
        ///     </para>                 
        /// </summary>
        public int SystemFileSize { get; set; }

        /// <summary>
        /// DB实例日志文件大小 
        ///     <para>
        ///     单位GB
        ///     </para>                 
        /// </summary>
        public int LogFileSize { get; set; }

        /// <summary>
        /// 如果列表操作 
        ///     <para>
        ///     则有从DB实例信息列表
        ///     </para>                 
        /// </summary>
        public List<DescribeUDBInstanceDataSet> DataSet { get; set; }

    }
}
