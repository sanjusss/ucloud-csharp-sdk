﻿using System;
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
    public class UNetTests
    {
        private UNet unet = new UNet(Config.PublicKey, Config.PrivateKey);

        [TestMethod()]
        public void AllocateEIPTest()
        {
            var entity = new AllocateEIPRequest(Config.region, OperatorName.Bgp.ToString(), 1);
            var response = unet.AllocateEIP(entity);
            Assert.AreEqual(response.RetCode,0);
        }

        [TestMethod()]
        public void AllocateVIPTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BindEIPTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateSecurityGroupTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteSecurityGroupTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DescribeEIPTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DescribeSecurityGroupTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DescribeSecurityGroupResourceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DescribeVIPTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetEIPPriceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GrantSecurityGroupTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModifyEIPBandwidthTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModifyEIPWeightTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReleaseEIPTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReleaseVIPTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UnBindEIPTest()
        {
            Assert.Fail();
        }
    }
}
