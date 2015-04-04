using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCloudSDK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UCloudSDK.Models;
using UCloudSDK.Test;

namespace UCloudSDK.Tests
{
    [TestClass()]
    public class SMSTests
    {
        UCloud ucloud = new UCloud(Config.PublicKey, Config.PrivateKey);

        [TestMethod()]
        public void SendSmsTest()
        {
            var phone = new NList();
            phone.Add("138xxxxxxxx");
            phone.Add("189xxxxxxxx");
            var content = "你好，Ucloud";
            var entity = new SMSRequest(phone, content);
            var response = ucloud.SendSms(entity);
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
