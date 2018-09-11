namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取弹性IP详细信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/unet/describe_eip.html
    ///     </para>
    /// </summary>
    public partial class DescribeEIPRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeEIP";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeEIP
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
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 弹性IP的资源ID如果为空 
        ///     <para>
        ///     则返回当前Region中符合条件的的所有EIP
        ///     </para>                 
        /// </summary>
        public NList EIPIds { get; set; }

        /// <summary>
        /// 数据偏移量 
        ///     <para>
        ///     默认为0
        ///     </para>                 
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// 数据分页值 
        ///     <para>
        ///     默认为20
        ///     </para>                 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeEIPRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeEIPRequest(string region)
        {               
            Region = region;
        }                
    }
}
