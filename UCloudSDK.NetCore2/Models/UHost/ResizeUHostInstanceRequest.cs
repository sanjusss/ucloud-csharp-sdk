namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改指定UHost实例的资源配置，如CPU核心数，内存容量大小，磁盘空间大小等。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/resize_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class ResizeUHostInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ResizeUHostInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ResizeUHostInstance
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
        /// UHost实例ID                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// 虚拟CPU核数 
        ///     <para>
        ///     单位：个，范围：[1,16]，最小值为1，其他值是2的倍数，默认值为当前实例的CPU核数
        ///     </para>                 
        /// </summary>
        public int? CPU { get; set; }

        /// <summary>
        /// 内存大小 
        ///     <para>
        ///     单位：MB，范围[2048,65536]，步长：2048，默认值为当前实例的内存大小
        ///     </para>                 
        /// </summary>
        public int? Memory { get; set; }

        /// <summary>
        /// 数据盘大小 
        ///     <para>
        ///     单位：GB，范围[10,1000]，步长：10，默认值为当前实例的数据盘大小，数据盘不支持缩容，因此不允许输入比当前实例数据盘大小的值
        ///     </para>                 
        /// </summary>
        public int? DiskSpace { get; set; }

        /// <summary>
        /// 实例化 <see cref="ResizeUHostInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        public ResizeUHostInstanceRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
