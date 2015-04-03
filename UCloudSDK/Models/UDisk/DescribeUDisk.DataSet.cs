namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取UDisk实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/describe_udisk.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDiskDataSet
    {
        /// <summary>
        /// UDisk实例Id                
        /// </summary>
        public string UDiskId { get; set; }

        /// <summary>
        /// 实例名称                
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 容量单位GB                
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 状态 
        ///     <para>
        ///     Available(可用),Attaching(挂载中),InUse(已挂载),Detaching(卸载中),
        ///     </para>                 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 创建时间                
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// 过期时间                
        /// </summary>
        public int ExpiredTime { get; set; }

        /// <summary>
        /// 挂载的UHost的Id                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// 挂载的UHost的Name                
        /// </summary>
        public string UHostName { get; set; }

        /// <summary>
        /// 挂载的UHost的IP                
        /// </summary>
        public string UHostIP { get; set; }

        /// <summary>
        /// 挂载的设备名称                
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Year 
        ///     <para>
        ///     Month,Dynamic,Trial
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

    }
}
