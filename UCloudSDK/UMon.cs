using RestSharp;
using UCloudSDK.Models;

namespace UCloudSDK
{
    /// <summary>
    /// 云监控
    /// </summary>
    public partial class UMon : UCloud
    {
        /// <summary>
        /// 初始化 <see cref="UMon"/> 类.
        /// </summary>
        public UMon()
        {
        }

        /// <summary>
        /// 初始化 <see cref="UMon"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        public UMon(string publicKey, string privateKey)
            : base(publicKey, privateKey)
        {
        }

        /// <summary>
        /// 初始化 <see cref="UMon"/> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        /// <param name="baseUrl">API请求地址.</param>
        public UMon(string publicKey, string privateKey, string baseUrl)
            : base(publicKey, privateKey, baseUrl)
        {
        }

        /// <summary>
        /// 获取监控数据
        /// </summary>
        /// <param name="requestParams">请求参数.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.GetMetricResponse"/></returns>
        public GetMetricResponse GetMetric(GetMetricRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<GetMetricResponse>(request);
        }

    }
}