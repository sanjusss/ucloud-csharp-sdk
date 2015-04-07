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
    public class UNetTests
    {
        private UNet unet = new UNet(Config.PublicKey, Config.PrivateKey);

        /// <summary>
        /// EIP Id,通过DescribeEIP()获得
        /// </summary>
        private string eipId = "eip-awo0gh";

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
            var entity = new AllocateVIPRequest(Config.region);
            var response = unet.AllocateVIP(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void BindEIPTest()
        {
            var entity = new BindEIPRequest(Config.region, eipId,MetricResourceType.uhost.ToString(),Config.UhostId);
            var response = unet.BindEIP(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateSecurityGroupTest()
        {
            NList rules=new NList();
            var rule = new SecurityGroupRule
            {
                Proto=Proto.TCP.ToString(),
                Action=RuleAction.ACCEPT.ToString(),
                Src_ip = "0.0.0.0/0",
                Dst_port = "3389",
                Priority = (int)Priority.Low
            };
            rules.Add(rule.ToString());
            var entity = new CreateSecurityGroupRequest(Config.region, "icyfre","ICCY", rules);
            var response = unet.CreateSecurityGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeleteSecurityGroupTest()
        {
            var entity = new DeleteSecurityGroupRequest(Config.region, "15031");
            var response = unet.DeleteSecurityGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeEIPTest()
        {
            var entity = new DescribeEIPRequest(Config.region);
            var response = unet.DescribeEIP(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeSecurityGroupTest()
        {
            var entity = new DescribeSecurityGroupRequest(Config.region);
            var response = unet.DescribeSecurityGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeSecurityGroupResourceTest()
        {
            var entity = new DescribeSecurityGroupResourceRequest(Config.region, "15031");
            var response = unet.DescribeSecurityGroupResource(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeVIPTest()
        {
            var entity = new DescribeVIPRequest(Config.region);
            var response = unet.DescribeVIP(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetEIPPriceTest()
        {
            var entity = new GetEIPPriceRequest(Config.region, OperatorName.Bgp.ToString(), 1);
            var response = unet.GetEIPPrice(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GrantSecurityGroupTest()
        {
            var entity = new GrantSecurityGroupRequest(Config.region, "15032","UHost",Config.UhostId);
            var response = unet.GrantSecurityGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ModifyEIPBandwidthTest()
        {
            var entity = new ModifyEIPBandwidthRequest(Config.region, eipId, 1);
            var response = unet.ModifyEIPBandwidth(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ModifyEIPWeightTest()
        {
            var entity = new ModifyEIPWeightRequest(Config.region, eipId, 2);
            var response = unet.ModifyEIPWeight(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ReleaseEIPTest()
        {
            var entity = new ReleaseEIPRequest(Config.region, eipId);
            var response = unet.ReleaseEIP(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ReleaseVIPTest()
        {
            var entity = new ReleaseVIPRequest(Config.region, "10.10.58.83");
            var response = unet.ReleaseVIP(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UnBindEIPTest()
        {
            var entity = new UnBindEIPRequest(Config.region, eipId, MetricResourceType.uhost.ToString(), Config.UhostId);
            var response = unet.UnBindEIP(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdateEIPAttributeTest()
        {
            var entity = new UpdateEIPAttributeRequest(Config.region,eipId);
            // Name Tag Remark都为空则报错
            entity.Tag = "eiptest";
            var response = unet.UpdateEIPAttribute(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdateSecurityGroupTest()
        {
            NList rules = new NList();
            var rule = new SecurityGroupRule
            {
                Proto = Proto.TCP.ToString(),
                Action = RuleAction.ACCEPT.ToString(),
                Src_ip = "0.0.0.0/0",
                Dst_port = "3389",
                Priority = (int)Priority.Low
            };
            rules.Add(rule.ToString());
            var entity = new UpdateSecurityGroupRequest(Config.region, "15031", rules);
            var response = unet.UpdateSecurityGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
