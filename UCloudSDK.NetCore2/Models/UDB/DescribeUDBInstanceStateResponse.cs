namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取udb实例状态
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_instance_state.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBInstanceStateResponse : UResponse
    {
        /// <summary>
        /// 响应动作                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// DB状态标记Init                      // 初始化中Fail                      // 安装失败Starting                  // 启动中Running                   // 运行Shutdown                  // 关闭中Shutoff                   // 已关闭Delete                    // 已删除Upgrading                 // 升级中Promoting                 // 提升为独库进行中Recovering                // 恢复中Recover fail              // 恢复失败                
        /// </summary>
        public string State { get; set; }

    }
}
