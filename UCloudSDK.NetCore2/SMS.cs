using RestSharp;
using UCloudSDK.Models;

namespace UCloudSDK
{
    public partial class UCloud
    {
        /// <summary>
        ///     发送短信.
        /// </summary>
        /// <param name="requestParams">短信发送对象.</param>
        /// <returns>返回对象<see cref="UCloudSDK.Models.SMSResponse" /></returns>
        public SMSResponse SendSms(SMSRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<SMSResponse>(request);
        }
    }
}