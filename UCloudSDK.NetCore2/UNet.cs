using RestSharp;
using UCloudSDK.Models;

namespace UCloudSDK
{
    /// <summary>
    /// 网络
    /// </summary>
    public partial class UNet : UCloud
    {
        /// <summary>
        /// 初始化 <see cref="UNet"/> 类.
        /// </summary>
        public UNet()
        {
        }

        /// <summary>
        /// 初始化 <see cref="UNet"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        public UNet(string publicKey, string privateKey)
            : base(publicKey, privateKey)
        {
        }

        /// <summary>
        /// 初始化 <see cref="UNet"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        /// <param name="baseUrl">API请求地址.</param>
        public UNet(string publicKey, string privateKey, string baseUrl)
            : base(publicKey, privateKey, baseUrl)
        {
        }

        /// <summary>
        /// 根据提供信息，分配弹性IP
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.AllocateEIPResponse"/></returns>
        public AllocateEIPResponse AllocateEIP(AllocateEIPRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<AllocateEIPResponse>(request);
        }

        /// <summary>
        /// 根据提供信息，分配内网VIP(Virtual IP，多用于高可用程序作为漂移IP。)
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.AllocateVIPResponse"/></returns>
        public AllocateVIPResponse AllocateVIP(AllocateVIPRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<AllocateVIPResponse>(request);
        }

        /// <summary>
        /// 将弹性IP绑定到资源上
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.BindEIPResponse"/></returns>
        public BindEIPResponse BindEIP(BindEIPRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<BindEIPResponse>(request);
        }

        /// <summary>
        /// 创建防火墙组
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.CreateSecurityGroupResponse"/></returns>
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateSecurityGroupResponse>(request);
        }

        /// <summary>
        /// 删除防火墙
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DeleteSecurityGroupResponse"/></returns>
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeleteSecurityGroupResponse>(request);
        }

        /// <summary>
        /// 获取弹性IP详细信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeEIPResponse"/></returns>
        public DescribeEIPResponse DescribeEIP(DescribeEIPRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeEIPResponse>(request);
        }

        /// <summary>
        /// 获取防火墙组信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeSecurityGroupResponse"/></returns>
        public DescribeSecurityGroupResponse DescribeSecurityGroup(DescribeSecurityGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeSecurityGroupResponse>(request);
        }

        /// <summary>
        /// 获取防火墙组所绑定资源的外网IP
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeSecurityGroupResourceResponse"/></returns>
        public DescribeSecurityGroupResourceResponse DescribeSecurityGroupResource(DescribeSecurityGroupResourceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeSecurityGroupResourceResponse>(request);
        }

        /// <summary>
        /// 获取内网VIP详细信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.DescribeVIPResponse"/></returns>
        public DescribeVIPResponse DescribeVIP(DescribeVIPRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeVIPResponse>(request);
        }

        /// <summary>
        /// 获取弹性IP价格
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.GetEIPPriceResponse"/></returns>
        public GetEIPPriceResponse GetEIPPrice(GetEIPPriceRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GetEIPPriceResponse>(request);
        }

        /// <summary>
        /// 将防火墙应用到资源上
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.GrantSecurityGroupResponse"/></returns>
        public GrantSecurityGroupResponse GrantSecurityGroup(GrantSecurityGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GrantSecurityGroupResponse>(request);
        }

        /// <summary>
        /// 修改弹性IP的外网带宽
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ModifyEIPBandwidthResponse"/></returns>
        public ModifyEIPBandwidthResponse ModifyEIPBandwidth(ModifyEIPBandwidthRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ModifyEIPBandwidthResponse>(request);
        }

        /// <summary>
        /// 修改弹性IP的外网出口权重
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ModifyEIPWeightResponse"/></returns>
        public ModifyEIPWeightResponse ModifyEIPWeight(ModifyEIPWeightRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ModifyEIPWeightResponse>(request);
        }

        /// <summary>
        /// 释放EIP资源
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ReleaseEIPResponse"/></returns>
        public ReleaseEIPResponse ReleaseEIP(ReleaseEIPRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ReleaseEIPResponse>(request);
        }

        /// <summary>
        /// 释放VIP资源
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.ReleaseVIPResponse"/></returns>
        public ReleaseVIPResponse ReleaseVIP(ReleaseVIPRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ReleaseVIPResponse>(request);
        }

        /// <summary>
        /// 将弹性IP从资源上解绑
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.UnBindEIPResponse"/></returns>
        public UnBindEIPResponse UnBindEIP(UnBindEIPRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UnBindEIPResponse>(request);
        }

        /// <summary>
        /// 修改EIP名字业务组备注等属性字段
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.UpdateEIPAttributeResponse"/></returns>
        public UpdateEIPAttributeResponse UpdateEIPAttribute(UpdateEIPAttributeRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UpdateEIPAttributeResponse>(request);
        }

        /// <summary>
        /// 更新防火墙规则
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.UpdateSecurityGroupResponse"/></returns>
        public UpdateSecurityGroupResponse UpdateSecurityGroup(UpdateSecurityGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UpdateSecurityGroupResponse>(request);
        }

    }
}