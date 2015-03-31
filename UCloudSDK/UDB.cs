using RestSharp;
using UCloudSDK.Models;

namespace UCloudSDK
{
    /// <summary>
    /// 云主机
    /// </summary>
    public class UDB : UCloud
    {
        /// <summary>
        /// 初始化 <see cref="UDB"/> 类.
        /// </summary>
        public UDB()
        {
        }

        /// <summary>
        /// 初始化 <see cref="UDB"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        public UDB(string publicKey, string privateKey)
            : base(publicKey, privateKey)
        {
        }

        /// <summary>
        /// 初始化 <see cref="UDB"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        /// <param name="baseUrl">API请求地址.</param>
        public UDB(string publicKey, string privateKey, string baseUrl)
            : base(publicKey, privateKey, baseUrl)
        {
        }

        /// <summary>
        /// 备份udb实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public BackupUDBInstanceResponse BackupUDBInstance(BackupUDBInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<BackupUDBInstanceResponse>(request);
        }

        /// <summary>
        /// 清除udb实例的log
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public ClearUDBLogResponse ClearUDBLog(ClearUDBLogRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ClearUDBLogResponse>(request);
        }

        /// <summary>
        /// 创建udb实例（包括mysql、mongodb实例和从备份恢复实例）
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public CreateUDBInstanceResponse CreateUDBInstance(CreateUDBInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateUDBInstanceResponse>(request);
        }

        /// <summary>
        /// 从已有配置文件创建新配置文件
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public CreateUDBParamGroupResponse CreateUDBParamGroup(CreateUDBParamGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateUDBParamGroupResponse>(request);
        }

        /// <summary>
        /// 创建mongodb的副本节点（包括仲裁）
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public CreateUDBReplicationInstanceResponse CreateUDBReplicationInstance(CreateUDBReplicationInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateUDBReplicationInstanceResponse>(request);
        }

        /// <summary>
        /// 创建udb实例的slave
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public CreateUDBSlaveResponse CreateUDBSlave(CreateUDBSlaveRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateUDBSlaveResponse>(request);
        }

        /// <summary>
        /// 删除udb实例备份
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DeleteUDBBackupResponse DeleteUDBBackup(DeleteUDBBackupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeleteUDBBackupResponse>(request);
        }

        /// <summary>
        /// 删除udb实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DeleteUDBInstanceResponse DeleteUDBInstance(DeleteUDBInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeleteUDBInstanceResponse>(request);
        }

        /// <summary>
        /// 删除配置参数组
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DeleteUDBParamGroupResponse DeleteUDBParamGroup(DeleteUDBParamGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeleteUDBParamGroupResponse>(request);
        }

        /// <summary>
        /// 列表udb实例备份信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeUDBBackupResponse DescribeUDBBackup(DescribeUDBBackupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDBBackupResponse>(request);
        }

        /// <summary>
        /// 获取udb实例的备份黑名单
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeUDBBackupBlacklistResponse DescribeUDBBackupBlacklist(DescribeUDBBackupBlacklistRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDBBackupBlacklistResponse>(request);
        }

        /// <summary>
        /// 获取udb实例信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeUDBInstanceResponse DescribeUDBInstance(DescribeUDBInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDBInstanceResponse>(request);
        }

        /// <summary>
        /// 获取udb实例价格信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeUDBInstancePriceResponse DescribeUDBInstancePrice(DescribeUDBInstancePriceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDBInstancePriceResponse>(request);
        }

        /// <summary>
        /// 获取udb实例状态
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeUDBInstanceStateResponse DescribeUDBInstanceState(DescribeUDBInstanceStateRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDBInstanceStateResponse>(request);
        }

        /// <summary>
        /// 获取参数组详细参数信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeUDBParamGroupResponse DescribeUDBParamGroup(DescribeUDBParamGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDBParamGroupResponse>(request);
        }

        /// <summary>
        /// 获取udb支持的类型信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeUDBTypeResponse DescribeUDBType(DescribeUDBTypeRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDBTypeResponse>(request);
        }

        /// <summary>
        /// 编辑udb实例的备份黑名单
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public EditUDBBackupBlacklistResponse EditUDBBackupBlacklist(EditUDBBackupBlacklistRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<EditUDBBackupBlacklistResponse>(request);
        }

        /// <summary>
        /// 重命名udb实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public ModifyUDBInstanceNameResponse ModifyUDBInstanceName(ModifyUDBInstanceNameRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ModifyUDBInstanceNameResponse>(request);
        }

        /// <summary>
        /// 从库提升为独立库
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public PromoteUDBSlaveResponse PromoteUDBSlave(PromoteUDBSlaveRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<PromoteUDBSlaveResponse>(request);
        }

        /// <summary>
        /// 重启udb实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public RestartUDBInstanceResponse RestartUDBInstance(RestartUDBInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<RestartUDBInstanceResponse>(request);
        }

        /// <summary>
        /// 启动udb实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public StartUDBInstanceResponse StartUDBInstance(StartUDBInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<StartUDBInstanceResponse>(request);
        }

        /// <summary>
        /// 关闭udb实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public StopUDBInstanceResponse StopUDBInstance(StopUDBInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<StopUDBInstanceResponse>(request);
        }

        /// <summary>
        /// 更新udb配置参数项
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public UpdateUDBParamGroupResponse UpdateUDBParamGroup(UpdateUDBParamGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UpdateUDBParamGroupResponse>(request);
        }

        /// <summary>
        /// 导入udb配置
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public UploadUDBParamGroupResponse UploadUDBParamGroup(UploadUDBParamGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UploadUDBParamGroupResponse>(request);
        }

    }
}
