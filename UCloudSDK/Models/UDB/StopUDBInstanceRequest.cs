namespace UCloudSDK.Models
{
    /// <summary>
    /// 关闭udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/stop_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class StopUDBInstanceRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     StopUDBInstance
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "StopUDBInstance";
            }
        }  
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     请参见数据中心RegionList
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 实例的Id                
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 实例化 <see cref="StopUDBInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">实例的Id</param>                    
        public StopUDBInstanceRequest(string region, string dbid)
        {               
            Region = region;
            DBId = dbid;
        }                
    }
}
