namespace UCloudSDK.Models
{
    /// <summary>
    /// 从已有配置文件创建新配置文件
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/create_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class CreateUDBParamGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateUDBParamGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateUDBParamGroup
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
        /// 新配置参数组名称                
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 参数组描述                
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 源参数组id                
        /// </summary>
        public int SrcGroupId { get; set; }

        /// <summary>
        /// DB类型id 
        ///     <para>
        ///     mysql/mongodb按版本细分各有一个id1：mysql-5.5，2：mysql-5.1，3：percona-5.54：mongodb-2.4，5：mongodb-2.6，6：mysql-5.6，7：percona-5.6
        ///     </para>                 
        /// </summary>
        public string DBTypeId { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateUDBParamGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="groupname">新配置参数组名称</param>                    
        /// <param name="description">参数组描述</param>                    
        /// <param name="srcgroupid">源参数组id</param>                    
        /// <param name="dbtypeid">DB类型id</param>                    
        public CreateUDBParamGroupRequest(string region, string groupname, string description, int srcgroupid, string dbtypeid)
        {               
            Region = region;
            GroupName = groupname;
            Description = description;
            SrcGroupId = srcgroupid;
            DBTypeId = dbtypeid;
        }                
    }
}
