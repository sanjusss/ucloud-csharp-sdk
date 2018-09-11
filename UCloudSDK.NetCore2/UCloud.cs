using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using RestSharp;
using RestSharp.Extensions;

namespace UCloudSDK
{
    /// <summary>
    ///     UCloud对象
    /// </summary>
    public partial class UCloud
    {
        /// <summary>
        ///     默认API请求地址
        ///     <para>可被App.Setting的BaseUrl覆盖</para>
        /// </summary>
        private const string Url = "http://api.ucloud.cn";

        /// <summary>
        ///     获取或设置API请求地址.
        /// </summary>
        /// <value>
        ///     API请求地址.
        /// </value>
        public string BaseUrl { get; set; }

        /// <summary>
        ///     获取或设置用户公钥.
        /// </summary>
        /// <value>
        ///     用户公钥.
        /// </value>
        public string PublicKey { get; set; }

        /// <summary>
        ///     获取或设置用户私钥.
        /// </summary>
        /// <value>
        ///     用户私钥.
        /// </value>
        public string PrivateKey { get; set; }

        /// <summary>
        ///     获取或设置RestClient对象.
        /// </summary>
        /// <value>
        ///     RestClient对象.
        /// </value>
        public RestClient Client { get; set; }

        /// <summary>
        ///     初始化 <see cref="UCloud" /> 类.
        ///     <para>
        ///         使用该构造函数，请正确配置App.Setting文件
        ///     </para>
        /// </summary>
        /// <exception cref="System.Exception">请正确配置App.Setting文件，或使用带参构造函数</exception>
        public UCloud()
        {
            var section = ConfigurationManager.GetSection("UcloudSetting") as NameValueCollection;
            if (section != null)
            {
                PublicKey = section["PublicKey"];
                PrivateKey = section["PrivateKey"];
                BaseUrl = section["BaseUrl"];
                BaseUrl = string.IsNullOrEmpty(BaseUrl) ? Url : BaseUrl;
                Client = new RestClient(BaseUrl) {UserAgent = "UCloudSDK"};
            }
            else
            {
                throw new Exception("请正确配置App.Setting文件，或使用带参构造函数");
            }
        }

        /// <summary>
        ///     初始化 <see cref="UCloud" /> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        public UCloud(string publicKey, string privateKey)
        {
            var section = ConfigurationManager.GetSection("UcloudSetting") as NameValueCollection;
            if (section != null)
            {
                BaseUrl = section["BaseUrl"];
            }
            BaseUrl = string.IsNullOrEmpty(BaseUrl) ? Url : BaseUrl;
            PublicKey = publicKey;
            PrivateKey = privateKey;
            Client = new RestClient(BaseUrl) {UserAgent = "UCloudSDK"};
        }

        /// <summary>
        ///     初始化 <see cref="UCloud" /> 类.
        /// </summary>
        /// <param name="publicKey">用户公钥.</param>
        /// <param name="privateKey">用户私钥.</param>
        /// <param name="baseUrl">API请求地址.</param>
        public UCloud(string publicKey, string privateKey, string baseUrl)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
            BaseUrl = baseUrl;
            Client = new RestClient(BaseUrl) {UserAgent = "UCloudSDK"};
        }

        /// <summary>
        ///     计算签名.
        /// </summary>
        /// <param name="parameters">参数键值对.</param>
        /// <returns>签名值</returns>
        private string VerfyAc(List<Parameter> parameters)
        {
            return VerfyAc(parameters, PrivateKey);
        }

        /// <summary>
        ///     计算签名.
        /// </summary>
        /// <param name="parameters">参数键值对.</param>
        /// <param name="privateKey">私钥.</param>
        /// <returns>签名值</returns>
        private string VerfyAc(List<Parameter> parameters, string privateKey)
        {
            var param=
            parameters.Where(t => t.Type == ParameterType.GetOrPost).ToList();

            param.Sort(delegate(Parameter x, Parameter y)
            {
                if (x.Name == null && y.Name == null) return 0;
                if (x.Name == null) return -1;
                if (y.Name == null) return 1;
                return String.Compare(x.Name, y.Name, StringComparison.Ordinal);
            });

            var sb = new StringBuilder();
            foreach (var parm in param)
            {
                sb.Append(parm.Name);
                sb.Append(parm.Value);
            }
            sb.Append(privateKey);

            return sb.ToString().ToSHA1();
        }

        /// <summary>
        ///     执行请求.
        /// </summary>
        /// <typeparam name="T">返回值类型</typeparam>
        /// <param name="request">请求对象.</param>
        /// <returns>返回值对象</returns>
        /// <exception cref="System.ApplicationException">异常</exception>
        public T Execute<T>(IRestRequest request) where T : new()
        {
            request.AddParameter("PublicKey", PublicKey);

            var sign = VerfyAc(request.Parameters);

            request.AddParameter("Signature", sign);

            var response = Client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "响应错误，请检查.";
                throw new ApplicationException(message, response.ErrorException);
            }

            return response.Data;
        }

        /// <summary>
        ///     执行请求.
        /// </summary>
        /// <typeparam name="T">返回值类型</typeparam>
        /// <param name="dictionary">请求对象.</param>
        /// <param name="method">HTTP请求方法类型</param>
        /// <returns>返回值对象</returns>
        /// <exception cref="System.ApplicationException">异常</exception>
        public T Execute<T>(Dictionary<string, string> dictionary, Method method = Method.GET) where T : new()
        {
            var request = new RestRequest(method);

            foreach (var kv in dictionary.Where(d => !d.Value.IsNullOrWhiteSpace()))
            {
                request.AddParameter(kv.Key, kv.Value);
            }

            return Execute<T>(request);
        }

#if NET4
    /// <summary>
    /// 执行请求.
    /// </summary>
    /// <param name="dictionary">请求对象.</param>
    /// <param name="method">HTTP请求方法类型.</param>
    /// <returns>动态类型</returns>
        public RestResponse<dynamic> Execute(Dictionary<string, string> dictionary, Method method = Method.GET)
        {

            var request = new RestRequest(method);

            foreach (var kv in dictionary.Where(d => !string.IsNullOrWhiteSpace(d.Value)))
            {
                request.AddParameter(kv.Key, kv.Value);
            }

            var sign = VerfyAc(request.Parameters);

            request.AddParameter("Signature", sign);

            return Client.ExecuteDynamic(request);
        }
#endif
    }
}