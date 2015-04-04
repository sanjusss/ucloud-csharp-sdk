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
    public class UMonTests
    {
        private UMon umon = new UMon(Config.PublicKey, Config.PrivateKey);

        [TestMethod()]
        public void GetMetricTest()
        {
            NList metricName = new NList();
            metricName.Add(UHostMetric.NetworkIn.ToString());
            //主机ID,替换为自己的
            string resourceId = "uhost-oeuax1";
            string resourceType = MetricResourceType.uhost.ToString();
            var entity = new GetMetricRequest(Config.region, metricName, resourceId, resourceType);
            var response = umon.GetMetric(entity);
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
