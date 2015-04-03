using RestSharp;
using UCloudSDK.Models;

namespace UCloudSDK
{
    /// <summary>
    /// 负载均衡
    /// </summary>
    public partial class ULB : UCloud
    {
        /// <summary>
        /// 初始化 <see cref="ULB"/> 类.
        /// </summary>
        public ULB()
        {
        }

        /// <summary>
        /// 初始化 <see cref="ULB"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        public ULB(string publicKey, string privateKey)
            : base(publicKey, privateKey)
        {
        }

        /// <summary>
        /// 初始化 <see cref="ULB"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        /// <param name="baseUrl">API请求地址.</param>
        public ULB(string publicKey, string privateKey, string baseUrl)
            : base(publicKey, privateKey, baseUrl)
        {
        }
        
        /// <summary>
        /// 添加ULB后端资源实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public AllocateBackendResponse AllocateBackend(AllocateBackendRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<AllocateBackendResponse>(request);
        }

        /// <summary>
        /// 将SSL证书绑定到VServer
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public BindSSLResponse BindSSL(BindSSLRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<BindSSLResponse>(request);
        }

        /// <summary>
        /// 创建内容转发策略
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreatePolicyResponse>(request);
        }

        /// <summary>
        /// 创建内容转发策略组
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public CreatePolicyGroupResponse CreatePolicyGroup(CreatePolicyGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreatePolicyGroupResponse>(request);
        }

        /// <summary>
        /// 添加SSL证书
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public CreateSSLResponse CreateSSL(CreateSSLRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateSSLResponse>(request);
        }

        /// <summary>
        /// 创建负载均衡实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public CreateULBResponse CreateULB(CreateULBRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateULBResponse>(request);
        }

        /// <summary>
        /// 创建VServer实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public CreateVServerResponse CreateVServer(CreateVServerRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateVServerResponse>(request);
        }

        /// <summary>
        /// 删除内容转发策略
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeletePolicyResponse>(request);
        }

        /// <summary>
        /// 删除内容转发策略组
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DeletePolicyGroupResponse DeletePolicyGroup(DeletePolicyGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeletePolicyGroupResponse>(request);
        }

        /// <summary>
        /// 删除SSL证书
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DeleteSSLResponse DeleteSSL(DeleteSSLRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeleteSSLResponse>(request);
        }

        /// <summary>
        /// 删除负载均衡实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DeleteULBResponse DeleteULB(DeleteULBRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeleteULBResponse>(request);
        }

        /// <summary>
        /// 删除VServer实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DeleteVServerResponse DeleteVServer(DeleteVServerRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DeleteVServerResponse>(request);
        }

        /// <summary>
        /// 显示内容转发策略组详情
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribePolicyGroupResponse DescribePolicyGroup(DescribePolicyGroupRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribePolicyGroupResponse>(request);
        }

        /// <summary>
        /// 显示SSL证书信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeSSLResponse DescribeSSL(DescribeSSLRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeSSLResponse>(request);
        }

        /// <summary>
        /// 显示负载均衡实例信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeULBResponse DescribeULB(DescribeULBRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeULBResponse>(request);
        }

        /// <summary>
        /// 释放ULB后端资源实例
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public ReleaseBackendResponse ReleaseBackend(ReleaseBackendRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<ReleaseBackendResponse>(request);
        }

        /// <summary>
        /// 修改ULB后端资源实例(主机池)属性
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public UpdateBackendAttributeResponse UpdateBackendAttribute(UpdateBackendAttributeRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UpdateBackendAttributeResponse>(request);
        }

        /// <summary>
        /// 修改内容转发策略组配置信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public UpdatePolicyGroupAttributeResponse UpdatePolicyGroupAttribute(UpdatePolicyGroupAttributeRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UpdatePolicyGroupAttributeResponse>(request);
        }

        /// <summary>
        /// 修改负载均衡实例属性
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public UpdateULBAttributeResponse UpdateULBAttribute(UpdateULBAttributeRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UpdateULBAttributeResponse>(request);
        }

        /// <summary>
        /// 修改VServer实例属性
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public UpdateVServerAttributeResponse UpdateVServerAttribute(UpdateVServerAttributeRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UpdateVServerAttributeResponse>(request);
        }

    }
}
