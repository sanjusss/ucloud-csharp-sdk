namespace UCloudSDK.Models
{
    /// <summary>
    /// 重命名udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/modify_udb_instance_name.html
    ///     </para>
    /// </summary>
    public partial class ModifyUDBInstanceNameRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "ModifyUDBInstanceName";

        /// <summary>
        /// API名称
        ///     <para>
        ///     ModifyUDBInstanceName
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
        /// 实例的Id                
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 实例的新名字                
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 实例化 <see cref="ModifyUDBInstanceNameRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">实例的Id</param>                    
        /// <param name="name">实例的新名字</param>                    
        public ModifyUDBInstanceNameRequest(string region, string dbid, string name)
        {               
            Region = region;
            DBId = dbid;
            Name = name;
        }                
    }
}
