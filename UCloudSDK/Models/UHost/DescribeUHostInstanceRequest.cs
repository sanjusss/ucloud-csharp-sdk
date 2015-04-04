namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取主机或主机列表信息，并可根据数据中心，主机ID等参数进行过滤。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class DescribeUHostInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DescribeUHostInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DescribeUHostInstance
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
        /// UHost主机的资源ID 
        ///     <para>
        ///     如果为空，则返回当前Region 所有符合条件的UHost实例
        ///     </para>                 
        /// </summary>
        public NList UHostIds { get; set; }

        /// <summary>
        /// 数据偏移量 
        ///     <para>
        ///     默认为0
        ///     </para>                 
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// 返回数据长度 
        ///     <para>
        ///     默认为20
        ///     </para>                 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// 实例化 <see cref="DescribeUHostInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        public DescribeUHostInstanceRequest(string region)
        {               
            Region = region;
        }                
    }
}
