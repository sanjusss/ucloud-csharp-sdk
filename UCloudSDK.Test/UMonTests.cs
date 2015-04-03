using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCloudSDK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.Fail();
        }
    }
}
