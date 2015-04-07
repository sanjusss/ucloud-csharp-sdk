using RestSharp;
using UCloudSDK.Models;

namespace UCloudSDK
{
    /// <summary>
    /// 云主机
    /// </summary>
    public partial class UHost : UCloud
    {
        /// <summary>
        /// 初始化 <see cref="UHost"/> 类.
        /// </summary>
        public UHost()
        {
        }

        /// <summary>
        /// 初始化 <see cref="UHost"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        public UHost(string publicKey, string privateKey)
            : base(publicKey, privateKey)
        {
        }

        /// <summary>
        /// 初始化 <see cref="UHost"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        /// <param name="baseUrl">API请求地址.</param>
        public UHost(string publicKey, string privateKey, string baseUrl)
            : base(publicKey, privateKey, baseUrl)
        {
        }

        /// <summary>
        /// 将一个可用的UDisk挂载到某台主机上，当UDisk挂载成功后，还需要在主机内部进行文件系统操作。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.AttachUDiskResponse"/></returns>
        public AttachUDiskResponse AttachUDisk(AttachUDiskRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<AttachUDiskResponse>(request);
        }

        /// <summary>
        /// 从指定UHost实例，生成自定义镜像。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.CreateCustomImageResponse"/></returns>
        public CreateCustomImageResponse CreateCustomImage(CreateCustomImageRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateCustomImageResponse>(request);
        }

        /// <summary>
        /// 指定数据中心，根据资源使用量创建指定数量的UHost实例。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.CreateUHostInstanceResponse"/></returns>
        public CreateUHostInstanceResponse CreateUHostInstance(CreateUHostInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateUHostInstanceResponse>(request);
        }

        /// <summary>
        /// 对指定UHost实例制作数据快照。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.CreateUHostInstanceSnapshotResponse"/></returns>
        public CreateUHostInstanceSnapshotResponse CreateUHostInstanceSnapshot(
            CreateUHostInstanceSnapshotRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateUHostInstanceSnapshotResponse>(request);
        }

        /// <summary>
        /// 获取指定数据中心镜像列表，用户可通过指定操作系统类型，镜像Id进行过滤。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeImageResponse"/></returns>
        public DescribeImageResponse DescribeImage(DescribeImageRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeImageResponse>(request);
        }

        /// <summary>
        /// 获取主机或主机列表信息，并可根据数据中心，主机ID等参数进行过滤。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeUHostInstanceResponse"/></returns>
        public DescribeUHostInstanceResponse DescribeUHostInstance(DescribeUHostInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUHostInstanceResponse>(request);
        }

        /// <summary>
        /// 获取已经存在的UHost实例的存储快照列表。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeUHostInstanceSnapshotResponse"/></returns>
        public DescribeUHostInstanceSnapshotResponse DescribeUHostInstanceSnapshot(
            DescribeUHostInstanceSnapshotRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUHostInstanceSnapshotResponse>(request);
        }

        /// <summary>
        /// 卸载某个已经挂载在指定UHost实例上的UDisk
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DetachUDiskResponse"/></returns>
        public DetachUDiskResponse DetachUDisk(DetachUDiskRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DetachUDiskResponse>(request);
        }

        /// <summary>
        /// 根据UHost实例配置，获取UHost实例的价格。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.GetUHostInstancePriceResponse"/></returns>
        public GetUHostInstancePriceResponse GetUHostInstancePrice(GetUHostInstancePriceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GetUHostInstancePriceResponse>(request);
        }

        /// <summary>
        /// 获取指定UHost实例的管理VNC配置详细信息。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.GetUHostInstanceVncInfoResponse"/></returns>
        public GetUHostInstanceVncInfoResponse GetUHostInstanceVncInfo(GetUHostInstanceVncInfoRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GetUHostInstanceVncInfoResponse>(request);
        }

        /// <summary>
        /// 修改指定UHost实例名称，需要给出数据中心，UHostId，及新的实例名称。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ModifyUHostInstanceNameResponse"/></returns>
        public ModifyUHostInstanceNameResponse ModifyUHostInstanceName(ModifyUHostInstanceNameRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ModifyUHostInstanceNameResponse>(request);
        }

        /// <summary>
        /// 修改指定UHost实例备注信息。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ModifyUHostInstanceRemarkResponse"/></returns>
        public ModifyUHostInstanceRemarkResponse ModifyUHostInstanceRemark(
            ModifyUHostInstanceRemarkRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ModifyUHostInstanceRemarkResponse>(request);
        }

        /// <summary>
        /// 修改指定UHost实例业务组标识。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ModifyUHostInstanceTagResponse"/></returns>
        public ModifyUHostInstanceTagResponse ModifyUHostInstanceTag(ModifyUHostInstanceTagRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ModifyUHostInstanceTagResponse>(request);
        }

        /// <summary>
        /// 重新启动UHost实例，需要指定数据中心及UHostID两个参数的值。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.RebootUHostInstanceResponse"/></returns>
        public RebootUHostInstanceResponse RebootUHostInstance(RebootUHostInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<RebootUHostInstanceResponse>(request);
        }

        /// <summary>
        /// 重新安装指定UHost实例的操作系统
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ReinstallUHostInstanceResponse"/></returns>
        public ReinstallUHostInstanceResponse ReinstallUHostInstance(ReinstallUHostInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ReinstallUHostInstanceResponse>(request);
        }

        /// <summary>
        /// 重置UHost实例的管理员密码。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ResetUHostInstancePasswordResponse"/></returns>
        public ResetUHostInstancePasswordResponse ResetUHostInstancePassword(
            ResetUHostInstancePasswordRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ResetUHostInstancePasswordResponse>(request);
        }

        /// <summary>
        /// 修改指定UHost实例的资源配置，如CPU核心数，内存容量大小，磁盘空间大小等。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ResizeUHostInstanceResponse"/></returns>
        public ResizeUHostInstanceResponse ResizeUHostInstance(ResizeUHostInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ResizeUHostInstanceResponse>(request);
        }

        /// <summary>
        /// 启动处于关闭状态的UHost实例，需要指定数据中心及UHostID两个参数的值。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.StartUHostInstanceResponse"/></returns>
        public StartUHostInstanceResponse StartUHostInstance(StartUHostInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<StartUHostInstanceResponse>(request);
        }

        /// <summary>
        /// 指停止处于运行状态的UHost实例，需指定数据中心及UhostID。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.StopUHostInstanceResponse"/></returns>
        public StopUHostInstanceResponse StopUHostInstance(StopUHostInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<StopUHostInstanceResponse>(request);
        }

        /// <summary>
        /// 删除用户自定义镜像
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.TerminateCustomImageResponse"/></returns>
        public TerminateCustomImageResponse TerminateCustomImage(TerminateCustomImageRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<TerminateCustomImageResponse>(request);
        }

        /// <summary>
        /// 删除指定数据中心的UHost实例。
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.TerminateUHostInstanceResponse"/></returns>
        public TerminateUHostInstanceResponse TerminateUHostInstance(TerminateUHostInstanceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<TerminateUHostInstanceResponse>(request);
        }
    }
}