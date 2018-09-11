namespace UCloudSDK.Models
{
    /// <summary>
    /// 更新udb配置参数项
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/update_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class UpdateUDBParamGroupRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "UpdateUDBParamGroup";

        /// <summary>
        /// API名称
        ///     <para>
        ///     UpdateUDBParamGroup
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
        /// 配置参数组id 
        ///     <para>
        ///     使用DescribeUDBParamGroup获得
        ///     </para>                 
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// 参数名称                
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 参数值                
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 实例化 <see cref="UpdateUDBParamGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="groupid">配置参数组id</param>                    
        /// <param name="key">参数名称</param>                    
        /// <param name="value">参数值</param>                    
        public UpdateUDBParamGroupRequest(string region, int groupid, string key, string value)
        {               
            Region = region;
            GroupId = groupid;
            Key = key;
            Value = value;
        }                
    }
}
