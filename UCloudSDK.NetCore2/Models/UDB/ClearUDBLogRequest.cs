namespace UCloudSDK.Models
{
    /// <summary>
    /// 清除udb实例的log
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/clear_udb_log.html
    ///     </para>
    /// </summary>
    public partial class ClearUDBLogRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ClearUDBLog";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ClearUDBLog
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
        ///     请参见数据中心RegionList
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 项目编号                
        /// </summary>
        public int? ProjectId { get; set; }

        /// <summary>
        /// DB实例的id                
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 日志类型 
        ///     <para>
        ///     10-error（暂不支持）、20-slow（暂不支持）、30-binlog
        ///     </para>                 
        /// </summary>
        public int LogType { get; set; }

        /// <summary>
        /// 删除时间点(至少前一天)之前log 
        ///     <para>
        ///     采用时间戳(秒)，默认当前时间点前一天
        ///     </para>                 
        /// </summary>
        public int? BeforeTime { get; set; }

        /// <summary>
        /// 实例化 <see cref="ClearUDBLogRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">DB实例的id</param>                    
        /// <param name="logtype">日志类型</param>                    
        public ClearUDBLogRequest(string region, string dbid, int logtype)
        {               
            Region = region;
            DBId = dbid;
            LogType = logtype;
        }                
    }
}
