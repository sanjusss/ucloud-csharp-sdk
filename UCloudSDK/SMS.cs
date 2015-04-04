using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using UCloudSDK.Models;

namespace UCloudSDK
{
    public partial class UCloud
    {
        /// <summary>
        /// 发送短信.
        /// </summary>
        /// <param name="requestParams">短信发送对象.</param>
        /// <returns></returns>
        public SMSResponse SendSms(SMSRequest requestParams)
        {
            var request = new RestRequest(Method.GET);
            request.AddUObject(requestParams);
            return Execute<SMSResponse>(request);
        }
    }
}
