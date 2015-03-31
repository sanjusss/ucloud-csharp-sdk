namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取防火墙组所绑定资源的外网IP
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_security_group_resource.html
    ///     </para>
    /// </summary>
    public partial class DescribeSecurityGroupResourceRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeSecurityGroupResource
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeSecurityGroupResource";
            }
        }  
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 防火墙ID                
        /// </summary>
        public int? GroupId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeSecurityGroupResourceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeSecurityGroupResourceRequest(string region)
        {               
            Region = region;
        }                
    }
}
