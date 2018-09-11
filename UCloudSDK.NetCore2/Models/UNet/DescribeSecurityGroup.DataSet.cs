using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取防火墙组信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_security_group.html
    ///     </para>
    /// </summary>
    public partial class DescribeSecurityGroupDataSet
    {
        /// <summary>
        /// 防火墙组的资源ID                
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 防火墙组的名称                
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 防火墙组创建时间 
        ///     <para>
        ///     格式为Unix Timestamp
        ///     </para>                 
        /// </summary>
        public string CreateTime { get; set; }

        /// <summary>
        /// 防火墙组类型 
        ///     <para>
        ///     枚举值为：0：用户自定义防火墙；1：默认Web防火墙；2：默认非Web防火墙
        ///     </para>                 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 防火墙组中的规则列表 
        ///     <para>
        ///     结构如下：
        ///     </para>                 
        /// </summary>
        public List<DescribeSecurityGroupRule> Rule { get; set; }

    }
}
