using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using UCloudSDK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UCloudSDK.Models;
using UCloudSDK.Test;

namespace UCloudSDK.Tests
{
    [TestClass()]
    public class UDBTests
    {
        private UDB udb = new UDB(Config.PublicKey, Config.PrivateKey);

        /// <summary>
        /// db实例id, 通过CreateUDBInstance获得
        /// </summary>
        private string dbid = "udb-hkdmou";
        /// <summary>
        /// 配置参数组id, 通过CreateUDBParamGroup获得
        /// </summary>
        private int groupId = 605;
        /// <summary>
        /// 备份id, 通过DescribeUDBBackup获得
        /// </summary>
        private int backupId = 252789;

        [TestMethod()]
        public void BackupUDBInstanceTest()
        {
            var entity = new BackupUDBInstanceRequest(Config.region, dbid, "ICYDBBUACKUP");
            var response = udb.BackupUDBInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ClearUDBLogTest()
        {
            var entity = new ClearUDBLogRequest(Config.region, dbid, (int)UDBLogType.binlog);
            var response = udb.ClearUDBLog(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateUDBInstanceTest()
        {
            var entity = new CreateUDBInstanceRequest(Config.region, "mysql-5.5", "ICYTESTDB", "ulv76dr19s", 3306, 3, 600, 20);
            entity.ChargeType = "Month";
            var response = udb.CreateUDBInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateUDBParamGroupTest()
        {
            var entity = new CreateUDBParamGroupRequest(Config.region, "ICYDBGROUP", "icydbconfig", 2, "mysql-5.1");
            var response = udb.CreateUDBParamGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateUDBReplicationInstanceTest()
        {
            //TODO:没钱了，创建不了
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateUDBSlaveTest()
        {
            //TODO:没钱了，创建不了
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteUDBBackupTest()
        {
            var entity = new DeleteUDBBackupRequest(Config.region, backupId);
            var response = udb.DeleteUDBBackup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeleteUDBInstanceTest()
        {
            var entity = new DeleteUDBInstanceRequest(Config.region, dbid);
            var response = udb.DeleteUDBInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DeleteUDBParamGroupTest()
        {
            var entity = new DeleteUDBParamGroupRequest(Config.region, 606);
            var response = udb.DeleteUDBParamGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDBBackupTest()
        {
            var entity = new DescribeUDBBackupRequest(Config.region, 0, 20);
            var response = udb.DescribeUDBBackup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDBBackupBlacklistTest()
        {
            var entity = new DescribeUDBBackupBlacklistRequest(Config.region, dbid);
            var response = udb.DescribeUDBBackupBlacklist(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDBInstanceTest()
        {
            var entity = new DescribeUDBInstanceRequest(Config.region);
            entity.Offset = 0;
            entity.Limit = 20;
            entity.ClassType = UDBClassType.SQL.ToString();
            var response = udb.DescribeUDBInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDBInstancePriceTest()
        {
            var entity = new DescribeUDBInstancePriceRequest(Config.region, 1, 600, 20);
            var response = udb.DescribeUDBInstancePrice(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDBInstanceStateTest()
        {
            var entity = new DescribeUDBInstanceStateRequest(Config.region, dbid);
            var response = udb.DescribeUDBInstanceState(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDBParamGroupTest()
        {
            var entity = new DescribeUDBParamGroupRequest(Config.region);
            entity.Offset = 0;
            entity.Limit = 20;
            var response = udb.DescribeUDBParamGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUDBTypeTest()
        {
            var entity = new DescribeUDBTypeRequest(Config.region);
            var response = udb.DescribeUDBType(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void EditUDBBackupBlacklistTest()
        {
            var entity = new EditUDBBackupBlacklistRequest(Config.region, dbid, "abc.%;user.%;city.address");
            var response = udb.EditUDBBackupBlacklist(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ModifyUDBInstanceNameTest()
        {
            var entity = new ModifyUDBInstanceNameRequest(Config.region, dbid, "ICYUCLOUDB");
            var response = udb.ModifyUDBInstanceName(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void PromoteUDBSlaveTest()
        {
            //TODO:没钱了，创建不了
            Assert.Fail();
        }

        [TestMethod()]
        public void RestartUDBInstanceTest()
        {
            var entity = new RestartUDBInstanceRequest(Config.region, dbid);
            var response = udb.RestartUDBInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void StartUDBInstanceTest()
        {
            var entity = new StartUDBInstanceRequest(Config.region, dbid);
            var response = udb.StartUDBInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void StopUDBInstanceTest()
        {
            var entity = new StopUDBInstanceRequest(Config.region, dbid);
            var response = udb.StopUDBInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UpdateUDBParamGroupTest()
        {
            var entity = new UpdateUDBParamGroupRequest(Config.region, groupId, "back_log", "200");
            var response = udb.UpdateUDBParamGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void UploadUDBParamGroupTest()
        {
            var content = @"W2NsaWVudF0NCiBwb3J0ID0gMzMwNg0KIHNvY2tldCA9IC90bXAvbXlzcWwuc29jaw0KIFtteWlzYW1jaGtdDQoga2V5X2J1ZmZlcl9zaXplID0gMjBNDQogcmVhZF9idWZmZXIgPSAyTQ0KIHNvcnRfYnVmZmVyX3NpemUgPSAyME0NCiB3cml0ZV9idWZmZXIgPSAyTQ0KIFtteXNxbF0NCiBuby1hdXRvLXJlaGFzaA0KIFtteXNxbGRdDQogYmFja19sb2cgPSAyMDAwDQogYmFzZWRpciA9IC9vcHQvdWRiL3Byb2dyYW0vbXlzcWwvbXlzcWwtNS42LjIwDQogYmluZC1hZGRyZXNzID0gMTAuNC40LjE2OA0KIGJpbmxvZy1mb3JtYXQgPSBNSVhFRA0KIGNoYXJhY3Rlcl9zZXRfc2VydmVyID0gdXRmOA0KIGRhdGFkaXIgPSAvb3B0L3VkYi9pbnN0YW5jZS9teXNxbC01LjYvMTdlMzRmNjktODRkZi00ZGZlLTkzMTgtNGY1YTVkODI0NDcyL2RhdGENCiBldmVudF9zY2hlZHVsZXIgPSBPTg0KIGV4cGlyZV9sb2dzX2RheXMgPSA3DQogZ2VuZXJhbC1sb2ctZmlsZSA9IC9vcHQvdWRiL2luc3RhbmNlL215c3FsLTUuNi8xN2UzNGY2OS04NGRmLTRkZmUtOTMxOC00ZjVhNWQ4MjQ0NzIvbG9nL215c3FsZC5sb2cNCiBpbm5vZGJfYnVmZmVyX3Bvb2xfc2l6ZSA9IDYyOTE0NTYwMA0KIGlubm9kYl9kYXRhX2ZpbGVfcGF0aCA9IGliZGF0YTE6MTAwTTphdXRvZXh0ZW5kDQogaW5ub2RiX2RhdGFfaG9tZV9kaXIgPSAvb3B0L3VkYi9pbnN0YW5jZS9teXNxbC01LjYvMTdlMzRmNjktODRkZi00ZGZlLTkzMTgtNGY1YTVkODI0NDcyL2RhdGENCiBpbm5vZGJfZmlsZV9wZXJfdGFibGUgPSAxDQogaW5ub2RiX2ZsdXNoX2xvZ19hdF90cnhfY29tbWl0ID0gMg0KIGlubm9kYl9mbHVzaF9tZXRob2QgPSBPX0RJUkVDVA0KIGlubm9kYl9pb19jYXBhY2l0eSA9IDIwMDANCiBpbm5vZGJfbG9nX2J1ZmZlcl9zaXplID0gODM4ODYwOA0KIGlubm9kYl9sb2dfZmlsZV9zaXplID0gNTEyTQ0KIGlubm9kYl9sb2dfZmlsZXNfaW5fZ3JvdXAgPSAyDQogaW5ub2RiX2xvZ19ncm91cF9ob21lX2RpciA9IC9vcHQvdWRiL2luc3RhbmNlL215c3FsLTUuNi8xN2UzNGY2OS04NGRmLTRkZmUtOTMxOC00ZjVhNWQ4MjQ0NzIvZGF0YQ0KIGlubm9kYl9tYXhfZGlydHlfcGFnZXNfcGN0ID0gNTANCiBpbm5vZGJfb3Blbl9maWxlcyA9IDEwMjQNCiBpbm5vZGJfcmVhZF9pb190aHJlYWRzID0gOA0KIGlubm9kYl90aHJlYWRfY29uY3VycmVuY3kgPSAyMA0KIGlubm9kYl93cml0ZV9pb190aHJlYWRzID0gOA0KIGtleV9idWZmZXJfc2l6ZSA9IDMzNTU0NDMyDQogbG9jYWxfaW5maWxlID0gMA0KIGxvZy1iaW4gPSAvb3B0L3VkYi9pbnN0YW5jZS9teXNxbC01LjYvMTdlMzRmNjktODRkZi00ZGZlLTkzMTgtNGY1YTVkODI0NDcyL2JpbmxvZy9teXNxbC1iaW4ubG9nDQogbG9nLWVycm9yID0gL29wdC91ZGIvaW5zdGFuY2UvbXlzcWwtNS42LzE3ZTM0ZjY5LTg0ZGYtNGRmZS05MzE4LTRmNWE1ZDgyNDQ3Mi9sb2cvbXlzcWxkLmxvZw0KbG9nX2Jpbl90cnVzdF9mdW5jdGlvbl9jcmVhdG9ycyA9IDENCiBsb2dfb3V0cHV0ID0gVEFCTEUNCiBsb25nX3F1ZXJ5X3RpbWUgPSAzDQogbWF4X2FsbG93ZWRfcGFja2V0ID0gMTY3NzcyMTYNCiBtYXhfY29ubmVjdF9lcnJvcnMgPSAxMDAwMDAwDQogbWF4X2Nvbm5lY3Rpb25zID0gMjAwMA0KIG15aXNhbV9zb3J0X2J1ZmZlcl9zaXplID0gODM4ODYwOA0KIG5ldF9idWZmZXJfbGVuZ3RoID0gODE5Mg0KIHBpZC1maWxlID0gL29wdC91ZGIvaW5zdGFuY2UvbXlzcWwtNS42LzE3ZTM0ZjY5LTg0ZGYtNGRmZS05MzE4LTRmNWE1ZDgyNDQ3Mi9teXNxbGQucGlkDQogcG9ydCA9IDMzMDYNCiBxdWVyeV9jYWNoZV9zaXplID0gMTY3NzcyMTYNCiByZWFkX2J1ZmZlcl9zaXplID0gMjYyMTQ0DQogcmVhZF9ybmRfYnVmZmVyX3NpemUgPSA1MjQyODgNCiByZWxheS1sb2cgPSAvb3B0L3VkYi9pbnN0YW5jZS9teXNxbC01LjYvMTdlMzRmNjktODRkZi00ZGZlLTkzMTgtNGY1YTVkODI0NDcyL3JlbGF5bG9nL215c3FsLXJlbGF5LmxvZw0KIHNlY3VyZS1maWxlLXByaXYgPSAvb3B0L3VkYi9pbnN0YW5jZS9teXNxbC01LjYvMTdlMzRmNjktODRkZi00ZGZlLTkzMTgtNGY1YTVkODI0NDcyL3RtcA0KIHNlcnZlci1pZCA9IDE2ODAzNTQ5Ng0KIHNraXAtc2xhdmUtc3RhcnQNCiBza2lwX25hbWVfcmVzb2x2ZQ0KIHNsYXZlLWxvYWQtdG1wZGlyID0gL29wdC91ZGIvaW5zdGFuY2UvbXlzcWwtNS42LzE3ZTM0ZjY5LTg0ZGYtNGRmZS05MzE4LTRmNWE1ZDgyNDQ3Mi90bXANCiBzbG93LXF1ZXJ5LWxvZy1maWxlID0gL29wdC91ZGIvaW5zdGFuY2UvbXlzcWwtNS42LzE3ZTM0ZjY5LTg0ZGYtNGRmZS05MzE4LTRmNWE1ZDgyNDQ3Mi9sb2cvbXlzcWwtc2xvdy5sb2cNCiBzbG93X3F1ZXJ5X2xvZyA9IDENCiBzb2NrZXQgPSAvb3B0L3VkYi9pbnN0YW5jZS9teXNxbC01LjYvMTdlMzRmNjktODRkZi00ZGZlLTkzMTgtNGY1YTVkODI0NDcyL215c3FsZC5zb2NrDQogc29ydF9idWZmZXJfc2l6ZSA9IDUyNDI4OA0KIHN5bmNfYmlubG9nID0gMQ0KIHRhYmxlX29wZW5fY2FjaGUgPSAxMjgNCiB0aHJlYWRfY2FjaGVfc2l6ZSA9IDUwDQogdG1wZGlyID0gL29wdC91ZGIvaW5zdGFuY2UvbXlzcWwtNS42LzE3ZTM0ZjY5LTg0ZGYtNGRmZS05MzE4LTRmNWE1ZDgyNDQ3Mi90bXANCiB1c2VyID0gbXlzcWwNCiBbbXlzcWxkX3NhZmVdDQogbG9nLWVycm9yID0gL29wdC91ZGIvaW5zdGFuY2UvbXlzcWwtNS42LzE3ZTM0ZjY5LTg0ZGYtNGRmZS05MzE4LTRmNWE1ZDgyNDQ3Mi9sb2cvbXlzcWxkLmxvZw0KIHBpZC1maWxlID0gL29wdC91ZGIvaW5zdGFuY2UvbXlzcWwtNS42LzE3ZTM0ZjY5LTg0ZGYtNGRmZS05MzE4LTRmNWE1ZDgyNDQ3Mi9teXNxbGQucGlkDQogW215c3FsZHVtcF0NCiBtYXhfYWxsb3dlZF9wYWNrZXQgPSAxNk0NCiBxdWljaw0KIFtteXNxbGhvdGNvcHldDQogaW50ZXJhY3RpdmUtdGltZW91dA0KIC9vcHQvdWRiL2luc3RhbmNlL215c3E%3D&DBTypeId=mysql-5.5&Description=test&GroupName=test1222&PublicKey=ucloudpmtest1%40ucloud.cn140474078895539362&Region=cn-east-01&Signature=941092ab104570b68b7d1b0af922b1174a81a50a";
            var entity = new UploadUDBParamGroupRequest(Config.region, "mysql-5.1", "ICYMA", "icyup", content);
            var response = udb.UploadUDBParamGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
