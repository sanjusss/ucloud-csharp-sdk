namespace UCloudSDK.Models
{
    /// <summary>
    /// 根据UHost实例配置，获取UHost实例的价格。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/get_uhost_instance_price.html
    ///     </para>
    /// </summary>
    public partial class GetUHostInstancePriceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "GetUHostInstancePrice";

        /// <summary>
        /// API名称
        ///     <para>
        ///     GetUHostInstancePrice
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
        /// 镜像Id 
        ///     <para>
        ///     参见 镜像列表
        ///     </para>                 
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 虚拟CPU核心数 
        ///     <para>
        ///     单位: 个，范围: [1,16]，最小值为1，其他值是2的整数倍
        ///     </para>                 
        /// </summary>
        public int CPU { get; set; }

        /// <summary>
        /// 内存容量大小 
        ///     <para>
        ///     单位: MB，范围: [2048,65536]，步长: 2048
        ///     </para>                 
        /// </summary>
        public int Memory { get; set; }

        /// <summary>
        /// 购买台数 
        ///     <para>
        ///     范围[1,5]
        ///     </para>                 
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Year 
        ///     <para>
        ///     Month，Dynamic，默认返回全部计费方式对应的价格
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 数据盘大小 
        ///     <para>
        ///     单位: GB，范围[0,1000]，步长: 10，默认值: 0
        ///     </para>                 
        /// </summary>
        public int? DiskSpace { get; set; }

        /// <summary>
        /// 实例化 <see cref="GetUHostInstancePriceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="imageid">镜像Id</param>                    
        /// <param name="cpu">虚拟CPU核心数</param>                    
        /// <param name="memory">内存容量大小</param>                    
        /// <param name="count">购买台数</param>                    
        public GetUHostInstancePriceRequest(string region, string imageid, int cpu, int memory, int count)
        {               
            Region = region;
            ImageId = imageid;
            CPU = cpu;
            Memory = memory;
            Count = count;
        }                
    }
}
