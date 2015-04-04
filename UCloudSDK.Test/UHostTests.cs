using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCloudSDK;
using UCloudSDK.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UCloudSDK.Models;

namespace UCloudSDK.Tests
{
    [TestClass()]
    public class UHostTests
    {
        UHost uhost = new UHost(Config.PublicKey, Config.PrivateKey);

        /// <summary>
        /// UHost Id
        /// <para>
        /// 创建UHost实例后得到
        /// </para>
        /// </summary>
        private string uhostid = "uhost-oeuax1";
        /// <summary>
        /// 镜像名称
        /// <para>
        /// 通过DescribeImage得到
        /// </para>
        /// </summary>
        private string uimageid = "uimage-34emui";

        /// <summary>
        /// 云硬盘ID，通过UDisk.DescribeUDisk获得
        /// </summary>
        private string uDiskId = "u0TD9595816accc04fc3a7cf34791a2c46dd";

        [TestMethod()]
        public void AttachUdiskTest()
        {
            var entity = new AttachUDiskRequest(Config.region, uhostid,uDiskId);
            var response = uhost.AttachUdisk(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateCustomImageTest()
        {
            var entity = new CreateCustomImageRequest(Config.region, uhostid,"testimage");
            var response = uhost.CreateCustomImage(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateUHostInstanceTest()
        {
            var entity = new CreateUHostInstanceRequest(Config.region, uimageid, "Password");
            //设置其它参数
            entity.CPU = 2;
            entity.Memory = 2048;
            entity.DiskSpace = 10;
            //密码需要进行BASE64编码
            var password = "Ucloud123";
            //使用string.ToBase64()进行编码
            entity.Password = password.ToBase64();
            entity.Name = "UCloudExample00";
            entity.ChargeType = "Month";
            entity.Quantity = 1;
            //请求API，返回类型为CreateUHostInstanceResponse
            var response = uhost.CreateUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateUHostInstanceSnapshotTest()
        {
            var entity = new CreateUHostInstanceSnapshotRequest(Config.region, uhostid);
            var response = uhost.CreateUHostInstanceSnapshot(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeImageTest()
        {
            var entity = new DescribeImageRequest(Config.region)
            {
                ImageType = "Base",
                OsType = OsType.Windows.ToString()
            };

            var response = uhost.DescribeImage(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUHostInstanceTest()
        {
            var entity = new DescribeUHostInstanceRequest(Config.region);
            var response = uhost.DescribeUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUHostInstanceSnapshotTest()
        {
            var entity = new DescribeUHostInstanceSnapshotRequest(Config.region,uhostid);
            var response = uhost.DescribeUHostInstanceSnapshot(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DetachUdiskTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUHostInstancePriceTest()
        {
            var entity = new GetUHostInstancePriceRequest(Config.region, uimageid, 2, 4096, 1);
            var response = uhost.GetUHostInstancePrice(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetUHostInstanceVncInfoTest()
        {
            var entity = new GetUHostInstanceVncInfoRequest(Config.region,uhostid);
            var response = uhost.GetUHostInstanceVncInfo(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ModifyUHostInstanceNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModifyUHostInstanceRemarkTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModifyUHostInstanceTagTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RebootUHostInstanceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReinstallUHostInstanceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ResetUHostInstancePasswordTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ResizeUHostInstanceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void StartUHostInstanceTest()
        {
            var entity = new StartUHostInstanceRequest(Config.region, uhostid);
            var response = uhost.StartUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void StopUHostInstanceTest()
        {
            var entity = new StopUHostInstanceRequest(Config.region, uhostid);
            var response = uhost.StopUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void TerminateCustomImageTest()
        {
            //镜像ID从创建镜像的返回值获得
            var uimage = "uimage-11al2d";
            var entity = new TerminateCustomImageRequest(Config.region, uimage);
            var response = uhost.TerminateCustomImage(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void TerminateUHostInstanceTest()
        {
            var entity = new TerminateUHostInstanceRequest(Config.region, uhostid);
            var response = uhost.TerminateUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
