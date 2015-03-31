namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除配置参数组
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/delete_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class DeleteUDBParamGroupRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     DeleteUDBParamGroup
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "DeleteUDBParamGroup";
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
        /// 参数组id                
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DeleteUDBParamGroupRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="groupid">参数组id</param>                    
        public DeleteUDBParamGroupRequest(string region, int groupid)
        {               
            Region = region;
            GroupId = groupid;
        }                
    }
}
