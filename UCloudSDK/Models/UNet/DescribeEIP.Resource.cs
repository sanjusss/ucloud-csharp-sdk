namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取弹性IP详细信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_eip.html
    ///     </para>
    /// </summary>
    public partial class DescribeEIPResource
    {
        /// <summary>
        /// 已绑定的资源类型                
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// 已绑定的资源名称                
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// 已绑定资源的资源ID                
        /// </summary>
        public string ResourceId { get; set; }

    }
}
