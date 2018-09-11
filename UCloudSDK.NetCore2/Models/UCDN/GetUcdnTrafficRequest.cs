namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取流量信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/get_ucdn_traffic.html
    ///     </para>
    /// </summary>
    public partial class GetUcdnTrafficRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "GetUcdnTraffic";

        /// <summary>
        /// API名称
        ///     <para>
        ///     GetUcdnTraffic
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }  
               
        /// <summary>
        /// None                
        /// </summary>
        public string 不需要提供参数 { get; set; }

    }
}
