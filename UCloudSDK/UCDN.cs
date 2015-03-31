using RestSharp;
using UCloudSDK.Models;

namespace UCloudSDK
{
    /// <summary>
    /// 云主机
    /// </summary>
    public class UCDN : UCloud
    {
        /// <summary>
        /// 初始化 <see cref="UCDN"/> 类.
        /// </summary>
        public UCDN()
        {
        }

        /// <summary>
        /// 初始化 <see cref="UCDN"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        public UCDN(string publicKey, string privateKey)
            : base(publicKey, privateKey)
        {
        }

        /// <summary>
        /// 初始化 <see cref="UCDN"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        /// <param name="baseUrl">API请求地址.</param>
        public UCDN(string publicKey, string privateKey, string baseUrl)
            : base(publicKey, privateKey, baseUrl)
        {
        }

        /// <summary>
        /// 购买流量
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public BuyUcdnTrafficResponse BuyUcdnTraffic(BuyUcdnTrafficRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<BuyUcdnTrafficResponse>(request);
        }

        /// <summary>
        /// 创建加速域名
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public CreateUcdnDomainResponse CreateUcdnDomain(CreateUcdnDomainRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<CreateUcdnDomainResponse>(request);
        }

        /// <summary>
        /// 获取域名预取任务状态
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribePrefetchCacheTaskResponse DescribePrefetchCacheTask(DescribePrefetchCacheTaskRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribePrefetchCacheTaskResponse>(request);
        }

        /// <summary>
        /// 获取域名刷新任务状态
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeRefreshCacheTaskResponse DescribeRefreshCacheTask(DescribeRefreshCacheTaskRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeRefreshCacheTaskResponse>(request);
        }

        /// <summary>
        /// 获取加速域名详细信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public DescribeUcdnDomainResponse DescribeUcdnDomain(DescribeUcdnDomainRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<DescribeUcdnDomainResponse>(request);
        }

        /// <summary>
        /// 获取加速域名带宽使用信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public GetUcdnDomainBandwidthResponse GetUcdnDomainBandwidth(GetUcdnDomainBandwidthRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GetUcdnDomainBandwidthResponse>(request);
        }

        /// <summary>
        /// 获取加速域名原始日志
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public GetUcdnDomainLogResponse GetUcdnDomainLog(GetUcdnDomainLogRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GetUcdnDomainLogResponse>(request);
        }

        /// <summary>
        /// 获取域名预取开启状态
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public GetUcdnDomainPrefetchEnableResponse GetUcdnDomainPrefetchEnable(GetUcdnDomainPrefetchEnableRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GetUcdnDomainPrefetchEnableResponse>(request);
        }

        /// <summary>
        /// 获取加速域名流量使用信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public GetUcdnDomainTrafficResponse GetUcdnDomainTraffic(GetUcdnDomainTrafficRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GetUcdnDomainTrafficResponse>(request);
        }

        /// <summary>
        /// 获取流量信息
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public GetUcdnTrafficResponse GetUcdnTraffic(GetUcdnTrafficRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GetUcdnTrafficResponse>(request);
        }

        /// <summary>
        /// 预取文件
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public PrefetchDomainCacheResponse PrefetchDomainCache(PrefetchDomainCacheRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<PrefetchDomainCacheResponse>(request);
        }

        /// <summary>
        /// 刷新加速缓存
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public RefreshUcdnDomainCacheResponse RefreshUcdnDomainCache(RefreshUcdnDomainCacheRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<RefreshUcdnDomainCacheResponse>(request);
        }

        /// <summary>
        /// 更新加速域名配置
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public UpdateUcdnDomainResponse UpdateUcdnDomain(UpdateUcdnDomainRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UpdateUcdnDomainResponse>(request);
        }

        /// <summary>
        /// 更新加速域名状态
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象</returns>
        public UpdateUcdnDomainStatusResponse UpdateUcdnDomainStatus(UpdateUcdnDomainStatusRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<UpdateUcdnDomainStatusResponse>(request);
        }

    }
}
