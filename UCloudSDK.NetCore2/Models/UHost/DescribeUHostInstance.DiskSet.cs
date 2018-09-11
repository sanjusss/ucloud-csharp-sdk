namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取主机或主机列表信息，并可根据数据中心，主机ID等参数进行过滤。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class DescribeUHostInstanceDiskSet
    {
        /// <summary>
        /// 系统盘 
        ///     <para>
        ///      Boot，数据盘: Data，网络盘: Udisk
        ///     </para>                 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 磁盘ID                
        /// </summary>
        public string DiskId { get; set; }

        /// <summary>
        /// 磁盘大小 
        ///     <para>
        ///     单位: GB
        ///     </para>                 
        /// </summary>
        public int Size { get; set; }

    }
}
