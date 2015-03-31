namespace UCloudSDK.Models
{
    /// <summary>
    /// 对指定UHost实例制作数据快照。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/create_uhost_instance_snapshot.html
    ///     </para>
    /// </summary>
    public partial class CreateUHostInstanceSnapshotResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     CreateUHostInstanceSnapshotResposne
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// UHost实例ID                
        /// </summary>
        public string UhostId { get; set; }

        /// <summary>
        /// 快照名称                
        /// </summary>
        public string SnapshotName { get; set; }

    }
}
