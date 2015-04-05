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
    public class ULBTests
    {
        private ULB ulb = new ULB(Config.PublicKey, Config.PrivateKey);

        /// <summary>
        /// 负载均衡实例的Id，通过CreateULB得到
        /// </summary>
        private string ulbId = "ulb-cw4etf";

        /// <summary>
        /// VServer实例的Id，通过CreateVServer得到
        /// </summary>
        private string vServerId = "287fc269-dba5-4e64-b1a7-7ff552d854ea";

        /// <summary>
        /// 后端资源实例的ID，通过CreateVServerAllocateBackend得到
        /// </summary>
        private string backendId = "0b854b3b-a076-4f84-a1ed-ed0662abb5a8";

        /// <summary>
        /// 内容转发策略ID，通过CreatePolicy得到
        /// </summary>
        private string policyId = "cdf5db34-f832-4c15-bfde-a9d73330ae48";

        /// <summary>
        /// 内容转发策略组的Id，通过CreatePolicyGroup得到
        /// </summary>
        private string groupId = "ulb-fr-otmnfe";

        [TestMethod()]
        public void AllocateBackendTest()
        {
            var entity = new AllocateBackendRequest(Config.region,ulbId,vServerId,"UHost",Config.UhostId);
            var response = ulb.AllocateBackend(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void BindSSLTest()
        {
            //TODO:木有证书。。测不了
            Assert.Fail();
        }

        [TestMethod()]
        public void CreatePolicyTest()
        {
            var back = new NList() {backendId};
            var entity = new CreatePolicyRequest(Config.region,groupId,"ok",ulbId,vServerId,back);
            var response = ulb.CreatePolicy(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreatePolicyGroupTest()
        {
            var entity = new CreatePolicyGroupRequest(Config.region);
            var response = ulb.CreatePolicyGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateSSLTest()
        {
            //TODO:木有证书。。测不了
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateULBTest()
        {
            var entity = new CreateULBRequest(Config.region);
            var response = ulb.CreateULB(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateVServerTest()
        {
            var entity = new CreateVServerRequest(Config.region,ulbId);
            var response = ulb.CreateVServer(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeletePolicyTest()
        {
            var entity = new DeletePolicyRequest(Config.region,groupId,policyId);
            var response = ulb.DeletePolicy(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeletePolicyGroupTest()
        {
            var entity = new DeletePolicyGroupRequest(Config.region, groupId);
            var response = ulb.DeletePolicyGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeleteSSLTest()
        {
            //TODO:木有证书。。测不了
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteULBTest()
        {
            var entity = new DeleteULBRequest(Config.region,ulbId);
            var response = ulb.DeleteULB(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeleteVServerTest()
        {
            var entity = new DeleteVServerRequest(Config.region, ulbId, vServerId);
            var response = ulb.DeleteVServer(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribePolicyGroupTest()
        {
            var entity = new DescribePolicyGroupRequest(Config.region);
            var response = ulb.DescribePolicyGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeSSLTest()
        {
            //TODO:木有证书。。测不了
            Assert.Fail();
        }

        [TestMethod()]
        public void DescribeULBTest()
        {
            var entity = new DescribeULBRequest(Config.region);
            var response = ulb.DescribeULB(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ReleaseBackendTest()
        {
            var entity = new ReleaseBackendRequest(Config.region, ulbId, backendId);
            var response = ulb.ReleaseBackend(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdateBackendAttributeTest()
        {
            var entity = new UpdateBackendAttributeRequest(Config.region, ulbId,backendId);
            entity.Port = 13456;
            var response = ulb.UpdateBackendAttribute(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdatePolicyGroupAttributeTest()
        {
            var entity = new UpdatePolicyGroupAttributeRequest(Config.region,groupId);
            entity.GroupName = "ICYGROUP";
            var response = ulb.UpdatePolicyGroupAttribute(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdateULBAttributeTest()
        {
            var entity = new UpdateULBAttributeRequest(Config.region,ulbId);
            entity.Name = "icyUlb";
            var response = ulb.UpdateULBAttribute(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdateVServerAttributeTest()
        {
            var entity = new UpdateVServerAttributeRequest(Config.region,ulbId,vServerId);
            entity.VServerName = "ICYVSER";
            var response = ulb.UpdateVServerAttribute(entity);
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
