namespace UCloudSDK.Models
{
    /// <summary>
    /// 导入udb配置
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/upload_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class UploadUDBParamGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UploadUDBParamGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UploadUDBParamGroup
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
        /// DB类型id 
        ///     <para>
        ///     mysql/mongodb按版本细分各有一个id1：mysql-5.5，2：mysql-5.1，3：percona-5.54：mongodb-2.4，5：mongodb-2.6，6：mysql-5.6，7：percona-5.6
        ///     </para>                 
        /// </summary>
        public string DBTypeId { get; set; }

        /// <summary>
        /// 配置参数组名称                
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 参数组描述                
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 配置内容
        /// </summary>
        private string _content;
        /// <summary>
        /// 配置内容 
        ///     <para>
        ///     导入的配置内容采用base64编码。mysql只支持[mysqld]段，如：[mysqld]back_log=102character_set_server=utf8......mongodb则不需要带段，如：auth=truemaxConns=2000......
        ///     </para>                 
        /// </summary>
        public string Content
        {
            get { return _content; }
            set { _content = value.ToBase64(); }
        }

        /// <summary>
        /// 实例化 <see cref="UploadUDBParamGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbtypeid">DB类型id</param>                    
        /// <param name="groupname">配置参数组名称</param>                    
        /// <param name="description">参数组描述</param>                    
        /// <param name="content">配置内容</param>                    
        public UploadUDBParamGroupRequest(string region, string dbtypeid, string groupname, string description, string content)
        {               
            Region = region;
            DBTypeId = dbtypeid;
            GroupName = groupname;
            Description = description;
            Content = content;
        }                
    }
}
