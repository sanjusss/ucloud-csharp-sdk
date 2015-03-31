using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取主机或主机列表信息，并可根据数据中心，主机ID等参数进行过滤。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class DescribeUHostInstanceUHostSet
    {
        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// UHost类型 
        ///     <para>
        ///     枚举为：Normal：普通机型；SSD：SSD高性能机型；BD：大数据机型
        ///     </para>                 
        /// </summary>
        public string UHostType { get; set; }

        /// <summary>
        /// 镜像ID                
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 基础镜像ID                
        /// </summary>
        public string BasicImageId { get; set; }

        /// <summary>
        /// 基础镜像名称                
        /// </summary>
        public string BasicImageName { get; set; }

        /// <summary>
        /// 业务组名称                
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 备注                
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// UHost实例名称                
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 实例状态 
        ///     <para>
        ///     初始化: Initializing; 启动中: Starting;运行中: Running; 关机中: Stopping; 关机: Stopped安装失败: Install Fail; 重启中: Rebooting
        ///     </para>                 
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 创建时间                
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// 计费模式 
        ///     <para>
        ///     枚举值为：Year，按年付费；Month，按月付费；Dynamic，按需付费（需开启权限）；Trial，试用（需开启权限）默认为月付
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 到期时间                
        /// </summary>
        public int ExpireTime { get; set; }

        /// <summary>
        /// 虚拟CPU核数 
        ///     <para>
        ///     单位: 个
        ///     </para>                 
        /// </summary>
        public int CPU { get; set; }

        /// <summary>
        /// 内存大小 
        ///     <para>
        ///     单位: MB
        ///     </para>                 
        /// </summary>
        public int Memory { get; set; }

        /// <summary>
        /// 磁盘信息                
        /// </summary>
        public List<DescribeUHostInstanceDiskSet> DiskSet { get; set; }

        /// <summary>
        /// IP信息                
        /// </summary>
        public List<DescribeUHostInstanceIPSet> IPSet { get; set; }

    }
}
