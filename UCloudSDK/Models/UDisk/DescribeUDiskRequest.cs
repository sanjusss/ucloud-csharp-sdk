namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取UDisk实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udisk/describe_udisk.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDiskRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUDisk";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUDisk
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        } 
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///      参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// UDisk Id(留空返回全部)                
        /// </summary>
        public string UDiskId { get; set; }

        /// <summary>
        /// 数据偏移量 
        ///     <para>
        ///      默认为0
        ///     </para>                 
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// 返回数据长度 
        ///     <para>
        ///      默认为20
        ///     </para>                 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeUDiskRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeUDiskRequest(string region)
        {               
            Region = region;
        }                
    }
}
