namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/delete_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class DeleteUDBInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "DeleteUDBInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     DeleteUDBInstance
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
        /// 实例化 <see cref="DeleteUDBInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">DB实例的id</param>                    
        public DeleteUDBInstanceRequest(string region, string dbid)
        {               
            Region = region;
            DBId = dbid;
        }                
    }
}
