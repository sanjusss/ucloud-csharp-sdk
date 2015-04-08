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

        /// <summary>
        /// SSL的Id，通过DescribeSSL得到
        /// </summary>
        private string sslId = "ssl-nsdsju";

        [TestMethod()]
        public void AllocateBackendTest()
        {
            var entity = new AllocateBackendRequest(Config.region, ulbId, vServerId, "UHost", Config.UhostId);
            var response = ulb.AllocateBackend(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void BindSSLTest()
        {
            var entity = new BindSSLRequest(Config.region,sslId, ulbId, vServerId);
            var response = ulb.BindSSL(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreatePolicyTest()
        {
            var back = new NList() { backendId };
            var entity = new CreatePolicyRequest(Config.region, groupId, "ok", ulbId, vServerId, back);
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
            #region ssl
            var content = @"subject= C = UK, O = OpenSSL Group, OU = FOR TESTING PURPOSES ONLY, CN = Test Server Cert #2
issuer= C = UK, O = OpenSSL Group, OU = FOR TESTING PURPOSES ONLY, CN = OpenSSL Test Intermediate CA
-----BEGIN CERTIFICATE-----
MIID6jCCAtKgAwIBAgIJALnu1NlVpZ60MA0GCSqGSIb3DQEBBQUAMHAxCzAJBgNV
BAYTAlVLMRYwFAYDVQQKDA1PcGVuU1NMIEdyb3VwMSIwIAYDVQQLDBlGT1IgVEVT
VElORyBQVVJQT1NFUyBPTkxZMSUwIwYDVQQDDBxPcGVuU1NMIFRlc3QgSW50ZXJt
ZWRpYXRlIENBMB4XDTExMTIwODE0MDE0OFoXDTIxMTAxNjE0MDE0OFowZzELMAkG
A1UEBhMCVUsxFjAUBgNVBAoMDU9wZW5TU0wgR3JvdXAxIjAgBgNVBAsMGUZPUiBU
RVNUSU5HIFBVUlBPU0VTIE9OTFkxHDAaBgNVBAMME1Rlc3QgU2VydmVyIENlcnQg
IzIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDrdi7j9yctG+L4EjBy
gjPmEqZzOJEQba26MoQGzglU7e5Xf59Rb/hgVQuKAoiZe7/R8rK4zJ4W7iXdXw0L
qBpyG8B5aGKeI32w+A9TcBApoXXL2CrYQEQjZwUIpLlYBIi2NkJj3nVkq5dgl1gO
ALiQ+W8jg3kzg5Ec9rimp9r93N8wsSL3awsafurmYCvOf7leHaMP1WJ/zDRGUNHG
/WtDjXc8ZUG1+6EXU9Jc2Fs+2Omf7fcN0l00AK/wPg8OaNS0rKyGq9JdIT9FRGV1
bXe/rx58FaE5CItdwCSYhJvF/O95LWQoxJXye5bCFLmvDTEyVq9FMSCptfsmbXjE
ZGsXAgMBAAGjgY8wgYwwDAYDVR0TAQH/BAIwADAOBgNVHQ8BAf8EBAMCBeAwLAYJ
YIZIAYb4QgENBB8WHU9wZW5TU0wgR2VuZXJhdGVkIENlcnRpZmljYXRlMB0GA1Ud
DgQWBBR52UaWWTKzZGDH/X4mWNcuqeQVazAfBgNVHSMEGDAWgBQ2w2yI55X+sL3s
zj49hqshgYfa2jANBgkqhkiG9w0BAQUFAAOCAQEANBW+XYLlHBqVY/31ie+3gRlS
LPfy4SIqn0t3RJjagT29MXprblBO2cbMO8VGjkQdKGpmMXjxbht2arOOUXRHX4n/
XTyn/QHEf0bcwIITMReO3DZUPAEw8hSjn9xEOM0IRVOCP+mH5fi74QzzQaZVCyYg
5VtLKdww/+sc0nCbKl2KWgDluriH0nfVx95qgW3mg9dhXRr0zmf1w2zkBHYpARYL
Dew6Z8EE4tS3HJu8/qM6meWzNtrfonQ3eiiMxjZBxzV46jchBwa2z9XYhP6AmpPb
oeTSzcQNbWsxaGYzWo46oLDUZmJOwSBawbS31bZNMCoPIY6ukoesCzFSsUKZww==
-----END CERTIFICATE-----
-----BEGIN RSA PRIVATE KEY-----
MIIEowIBAAKCAQEA63Yu4/cnLRvi+BIwcoIz5hKmcziREG2tujKEBs4JVO3uV3+f
UW/4YFULigKImXu/0fKyuMyeFu4l3V8NC6gachvAeWhiniN9sPgPU3AQKaF1y9gq
2EBEI2cFCKS5WASItjZCY951ZKuXYJdYDgC4kPlvI4N5M4ORHPa4pqfa/dzfMLEi
92sLGn7q5mArzn+5Xh2jD9Vif8w0RlDRxv1rQ413PGVBtfuhF1PSXNhbPtjpn+33
DdJdNACv8D4PDmjUtKyshqvSXSE/RURldW13v68efBWhOQiLXcAkmISbxfzveS1k
KMSV8nuWwhS5rw0xMlavRTEgqbX7Jm14xGRrFwIDAQABAoIBAHLsTPihIfLnYIE5
x4GsQQ5zXeBw5ITDM37ktwHnQDC+rIzyUl1aLD1AZRBoKinXd4lOTqLZ4/NHKx4A
DYr58mZtWyUmqLOMmQVuHXTZBlp7XtYuXMMNovQwjQlp9LicBeoBU6gQ5PVMtubD
F4xGF89Sn0cTHW3iMkqTtQ5KcR1j57OcJO0FEb1vPvk2MXI5ZyAatUYE7YacbEzd
rg02uIwx3FqNSkuSI79uz4hMdV5TPtuhxx9nTwj9aLUhXFeZ0mn2PVgVzEnnMoJb
+znlsZDgzDlJqdaD744YGWh8Z3OEssB35KfzFcdOeO6yH8lmv2Zfznk7pNPT7LTb
Lae9VgkCgYEA92p1qnAB3NtJtNcaW53i0S5WJgS1hxWKvUDx3lTB9s8X9fHpqL1a
E94fDfWzp/hax6FefUKIvBOukPLQ6bYjTMiFoOHzVirghAIuIUoMI5VtLhwD1hKs
Lr7l/dptMgKb1nZHyXoKHRBthsy3K4+udsPi8TzMvYElgEqyQIe/Rk0CgYEA86GL
8HC6zLszzKERDPBxrboRmoFvVUCTQDhsfj1M8aR3nQ8V5LkdIJc7Wqm/Ggfk9QRf
rJ8M2WUMlU5CNnCn/KCrKzCNZIReze3fV+HnKdbcXGLvgbHPrhnz8yYehUFG+RGq
bVyDWRU94T38izy2s5qMYrMJWZEYyXncSPbfcPMCgYAtaXfxcZ+V5xYPQFARMtiX
5nZfggvDoJuXgx0h3tK/N2HBfcaSdzbaYLG4gTmZggc/jwnl2dl5E++9oSPhUdIG
3ONSFUbxsOsGr9PBvnKd8WZZyUCXAVRjPBzAzF+whzQNWCZy/5htnz9LN7YDI9s0
5113Q96cheDZPFydZY0hHQKBgQDVbEhNukM5xCiNcu+f2SaMnLp9EjQ4h5g3IvaP
5B16daw/Dw8LzcohWboqIxeAsze0GD/D1ZUJAEd0qBjC3g+a9BjefervCjKOzXng
38mEUm+6EwVjJSQcjSmycEs+Sr/kwr/8i5WYvU32+jk4tFgMoC+o6tQe/Uesf68k
z/dPVwKBgGbF7Vv1/3SmhlOy+zYyvJ0CrWtKxH9QP6tLIEgEpd8x7YTSuCH94yok
kToMXYA3sWNPt22GbRDZ+rcp4c7HkDx6I6vpdP9aQEwJTp0EPy0sgWr2XwYmreIQ
NFmkk8Itn9EY2R9VBaP7GLv5kvwxDdLAnmwGmzVtbmaVdxCaBwUk
-----END RSA PRIVATE KEY-----
";
            #endregion
            var entity = new CreateSSLRequest(Config.region,"icyssl",content);
            var response = ulb.CreateSSL(entity);
            Assert.AreEqual(response.RetCode, 0);
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
            var entity = new CreateVServerRequest(Config.region, ulbId);
            var response = ulb.CreateVServer(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeletePolicyTest()
        {
            var entity = new DeletePolicyRequest(Config.region, groupId, policyId);
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
            var entity = new DeleteSSLRequest(Config.region, sslId);
            var response = ulb.DeleteSSL(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeleteULBTest()
        {
            var entity = new DeleteULBRequest(Config.region, ulbId);
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
            var entity = new DescribeSSLRequest(Config.region);
            var response = ulb.DescribeSSL(entity);
            Assert.AreEqual(response.RetCode, 0);
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
            var entity = new UpdateBackendAttributeRequest(Config.region, ulbId, backendId);
            entity.Port = 13456;
            var response = ulb.UpdateBackendAttribute(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdatePolicyGroupAttributeTest()
        {
            var entity = new UpdatePolicyGroupAttributeRequest(Config.region, groupId);
            entity.GroupName = "ICYGROUP";
            var response = ulb.UpdatePolicyGroupAttribute(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdateULBAttributeTest()
        {
            var entity = new UpdateULBAttributeRequest(Config.region, ulbId);
            entity.Name = "icyUlb";
            var response = ulb.UpdateULBAttribute(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdateVServerAttributeTest()
        {
            var entity = new UpdateVServerAttributeRequest(Config.region, ulbId, vServerId);
            entity.VServerName = "ICYVSER";
            var response = ulb.UpdateVServerAttribute(entity);
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
