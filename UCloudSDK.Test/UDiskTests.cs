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
        UDisk udisk = new UDisk(Config.PublicKey, Config.PrivateKey);

        /// <summary>
        /// 云硬盘ID，通过UDisk.DescribeUDisk获得
        /// </summary>
        private string uDiskId = "u0TD9595816accc04fc3a7cf34791a2c46dd";
        /// <summary>
        /// 云硬盘ID，通过DescribeUDiskSnapshot获得
        /// </summary>
        private string snapshotId = "1oHDad58598f5a334db4933a09ffe61a2125";

        [TestMethod()]
        public void AttachUDiskTest()
        {
            var entity = new AttachUDiskRequest(Config.region, Config.UhostId, uDiskId);
            var response = udisk.AttachUDisk(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CloneUDiskTest()
        {
            //TODO: RetCode=140 Message=User permissions
            var entity = new CloneUDiskRequest(Config.region, uDiskId, 1);
            var response = udisk.CloneUDisk(entity);
            Assert.Fail();
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CloneUDiskSnapshotTest()
        {
            //TODO: RetCode=140 Message=User permissions
            var entity = new CloneUDiskSnapshotRequest(Config.region, snapshotId, 10);
            var response = udisk.CloneUDiskSnapshot(entity);
            Assert.Fail();
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateUDiskTest()
        {
            //TODO: RetCode=7061 Message=create error
            var entity = new CreateUDiskRequest(Config.region, "icudsk", 1);
            var response = udisk.CreateUDisk(entity);
            Assert.Fail();
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateUDiskSnapshotTest()
        {
            //TODO：返回缺少RetCode=230 Message=Params [Comment] not available
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteUDiskTest()
        {
            var entity = new DeleteUDiskRequest(Config.region, uDiskId);
            var response = udisk.DeleteUDisk(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeleteUDiskSnapshotTest()
        {
            var entity = new DeleteUDiskSnapshotRequest(Config.region, snapshotId);
            var response = udisk.DeleteUDiskSnapshot(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDiskTest()
        {
            var entity = new DescribeUDiskRequest(Config.region);
            var response = udisk.DescribeUDisk(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDiskPriceTest()
        {
            var entity = new DescribeUDiskPriceRequest(Config.region, 200);
            var response = udisk.DescribeUDiskPrice(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDiskSnapshotTest()
        {
            var entity = new DescribeUDiskSnapshotRequest(Config.region);
            var response = udisk.DescribeUDiskSnapshot(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDiskUpgradePriceTest()
        {
            var entity = new DescribeUDiskUpgradePriceRequest(Config.region, uDiskId, 200);
            var response = udisk.DescribeUDiskUpgradePrice(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DetachUDiskTest()
        {
            var entity = new DetachUDiskRequest(Config.region, Config.UhostId, uDiskId);
            var response = udisk.DetachUDisk(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void RenameUDiskTest()
        {
            //TODO：估计Action错误，RetCode=150 Message=Service unavailable
            var entity = new RenameUDiskRequest(Config.region, uDiskId, "icynewdisk");
            var response = udisk.RenameUDisk(entity);
            Assert.Fail();
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ResizeUDiskTest()
        {
            //TODO: RetCode=140 Message=User permissions
            var entity = new ResizeUDiskRequest(Config.region, uDiskId,2);
            var response = udisk.ResizeUDisk(entity);
            Assert.Fail();
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
