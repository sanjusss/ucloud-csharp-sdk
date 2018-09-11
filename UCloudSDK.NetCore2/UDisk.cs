using RestSharp;
using UCloudSDK.Models;

namespace UCloudSDK
{
    /// <summary>
    /// 云硬盘
    /// </summary>
    public partial class UDisk : UCloud
    {
        /// <summary>
        /// 初始化 <see cref="UDisk"/> 类.
        /// </summary>
        public UDisk()
        {
        }

        /// <summary>
        /// 初始化 <see cref="UDisk"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        public UDisk(string publicKey, string privateKey)
            : base(publicKey, privateKey)
        {
        }

        /// <summary>
        /// 初始化 <see cref="UDisk"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        /// <param name="baseUrl">API请求地址.</param>
        public UDisk(string publicKey, string privateKey, string baseUrl)
            : base(publicKey, privateKey, baseUrl)
        {
        }

        /// <summary>
        /// 将一个可用的UDisk挂载到某台主机上，当UDisk挂载成功后，还需要在主机内部进行文件系统操作
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
        /// 从UDisk创建UDisk克隆
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.CloneUDiskResponse"/></returns>
        public CloneUDiskResponse CloneUDisk(CloneUDiskRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CloneUDiskResponse>(request);
        }

        /// <summary>
        /// 从快照创建UDisk克隆
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.CloneUDiskSnapshotResponse"/></returns>
        public CloneUDiskSnapshotResponse CloneUDiskSnapshot(CloneUDiskSnapshotRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CloneUDiskSnapshotResponse>(request);
        }

        /// <summary>
        /// 创建UDisk磁盘
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.CreateUDiskResponse"/></returns>
        public CreateUDiskResponse CreateUDisk(CreateUDiskRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateUDiskResponse>(request);
        }

        /// <summary>
        /// 创建snapshot快照
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.CreateUDiskSnapshotResponse"/></returns>
        public CreateUDiskSnapshotResponse CreateUDiskSnapshot(CreateUDiskSnapshotRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateUDiskSnapshotResponse>(request);
        }

        /// <summary>
        /// 删除UDisk
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DeleteUDiskResponse"/></returns>
        public DeleteUDiskResponse DeleteUDisk(DeleteUDiskRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeleteUDiskResponse>(request);
        }

        /// <summary>
        /// 销毁Snapshot
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DeleteUDiskSnapshotResponse"/></returns>
        public DeleteUDiskSnapshotResponse DeleteUDiskSnapshot(DeleteUDiskSnapshotRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeleteUDiskSnapshotResponse>(request);
        }

        /// <summary>
        /// 获取UDisk实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeUDiskResponse"/></returns>
        public DescribeUDiskResponse DescribeUDisk(DescribeUDiskRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDiskResponse>(request);
        }

        /// <summary>
        /// 获取udisk实例价格信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeUDiskPriceResponse"/></returns>
        public DescribeUDiskPriceResponse DescribeUDiskPrice(DescribeUDiskPriceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDiskPriceResponse>(request);
        }

        /// <summary>
        /// 获取UDisk快照
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeUDiskSnapshotResponse"/></returns>
        public DescribeUDiskSnapshotResponse DescribeUDiskSnapshot(DescribeUDiskSnapshotRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDiskSnapshotResponse>(request);
        }

        /// <summary>
        /// 获取udisk升级价格信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeUDiskUpgradePriceResponse"/></returns>
        public DescribeUDiskUpgradePriceResponse DescribeUDiskUpgradePrice(DescribeUDiskUpgradePriceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUDiskUpgradePriceResponse>(request);
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
        /// 重命名UDisk
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.RenameUDiskResponse"/></returns>
        public RenameUDiskResponse RenameUDisk(RenameUDiskRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<RenameUDiskResponse>(request);
        }

        /// <summary>
        /// 调整UDisk容量
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ResizeUDiskResponse"/></returns>
        public ResizeUDiskResponse ResizeUDisk(ResizeUDiskRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ResizeUDiskResponse>(request);
        }

    }
}