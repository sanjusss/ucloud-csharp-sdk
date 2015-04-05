using System;
using System.Collections.Generic;
using System.Configuration;
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
    public class UCDNTests
    {
        private UCDN ucdn = new UCDN(Config.PublicKey, Config.PrivateKey);

        /// <summary>
        /// 域名ID，创建加速域名CreateUcdnDomain时生成
        /// </summary>
        private string domainId = "ucdn-0uzyty";

        [TestMethod()]
        public void BuyUcdnTrafficTest()
        {
            var entity = new BuyUcdnTrafficRequest(1, Areacode.cn.ToString());
            var response = ucdn.BuyUcdnTraffic(entity);
            Assert.AreEqual(response.RetCode,0);
        }

        [TestMethod()]
        public void CreateUcdnDomainTest()
        {
            NList areaCodes=new NList();
            areaCodes.Add(Areacode.cn.ToString());
            var entity = new CreateUcdnDomainRequest("icyflash.com", areaCodes, CdnType.web.ToString());
            entity.TestUrl = "http://icyflash.com/test";
            entity.SourceIp =new NList(){"1.1.1.1"};
            var response = ucdn.CreateUcdnDomain(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribePrefetchCacheTaskTest()
        {
            var entity = new DescribePrefetchCacheTaskRequest(domainId);
            var response = ucdn.DescribePrefetchCacheTask(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeRefreshCacheTaskTest()
        {
            var entity = new DescribeRefreshCacheTaskRequest(domainId);
            var response = ucdn.DescribeRefreshCacheTask(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUcdnDomainTest()
        {
            var entity = new DescribeUcdnDomainRequest();
            entity.DomainIds=new NList() { domainId };
            var response = ucdn.DescribeUcdnDomain(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetUcdnDomainBandwidthTest()
        {
            var entity = new GetUcdnDomainBandwidthRequest();
            var response = ucdn.GetUcdnDomainBandwidth(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetUcdnDomainLogTest()
        {
            var entity = new GetUcdnDomainLogRequest();
            var response = ucdn.GetUcdnDomainLog(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetUcdnDomainPrefetchEnableTest()
        {
            var entity = new GetUcdnDomainPrefetchEnableRequest(domainId);
            var response = ucdn.GetUcdnDomainPrefetchEnable(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetUcdnDomainTrafficTest()
        {
            var entity = new GetUcdnDomainTrafficRequest();
            var response = ucdn.GetUcdnDomainTraffic(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetUcdnTrafficTest()
        {
            var entity = new GetUcdnTrafficRequest();
            var response = ucdn.GetUcdnTraffic(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void PrefetchDomainCacheTest()
        {
            NList urls = new NList { "http://abc.com/" };
            var entity = new PrefetchDomainCacheRequest(domainId, urls);
            var response = ucdn.PrefetchDomainCache(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void RefreshUcdnDomainCacheTest()
        {
            NList urls = new NList {"http://icyflash.com/test"};
            var entity = new RefreshUcdnDomainCacheRequest(domainId,CDNRefreshType.dir.ToString(),urls);
            var response = ucdn.RefreshUcdnDomainCache(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdateUcdnDomainTest()
        {
            var entity = new UpdateUcdnDomainRequest(domainId);
            entity.SourceIp=new NList(){"2.2.2.2"};
            entity.Areacode=new NList(){Areacode.abroad.ToString()};
            entity.CacheFileType=new NList(){"zip"};
            entity.CacheUrl=new NList(){"http://www.icyflash.com/t1"};
            entity.NoCacheUrl = new NList() { "http://www.icyflash.com/nt1" };
            var response = ucdn.UpdateUcdnDomain(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdateUcdnDomainStatusTest()
        {
            var entity = new UpdateUcdnDomainStatusRequest(domainId,UcdnDomainStatus.disable.ToString());
            var response = ucdn.UpdateUcdnDomainStatus(entity);
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
