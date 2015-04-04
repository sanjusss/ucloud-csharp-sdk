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
    public class UDiskTests
    {
        UDisk udisk=new UDisk(Config.PublicKey,Config.PrivateKey);

        [TestMethod()]
        public void AttachUdiskTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CloneUDiskTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CloneUDiskSnapshotTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateUDiskTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateUDiskSnapshotTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteUDiskTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteUDiskSnapshotTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DescribeUDiskTest()
        {
            var entity = new DescribeUDiskRequest(Config.region);
            var response = udisk.DescribeUDisk(entity);
            Assert.AreEqual(response.RetCode,0);
        }

        [TestMethod()]
        public void DescribeUDiskPriceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DescribeUDiskSnapshotTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DescribeUDiskUpgradePriceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DetachUDiskTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RenameUDiskTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ResizeUDiskTest()
        {
            Assert.Fail();
        }
    }
}
