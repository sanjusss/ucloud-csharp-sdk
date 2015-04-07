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
        /// MYSQL实例id, 通过CreateUDBInstance获得
        /// </summary>
        private string dbid = "udb-hkdmou";
        /// <summary>
        /// Mongo实例id, 通过CreateUDBInstance获得
        /// </summary>
        private string mgDBId = "udb-s1hq2v";
        /// <summary>
        /// 配置参数组id, 通过CreateUDBParamGroup获得
        /// </summary>
        private int groupId = 605;
        /// <summary>
        /// 备份id, 通过DescribeUDBBackup获得
        /// </summary>
        private int backupId = 252789;
        /// <summary>
        /// slave的DBId, 通过CreateUDBSlave获得
        /// </summary>
        private string slaveId = "udb-52be3l";

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
        public void CreateMDBInstanceTest()
        {
            var entity = new CreateUDBInstanceRequest(Config.region, "mongodb-2.6", "ICYMGDB", "ulv76dr19s", 3306, 3, 600, 20);
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
            var entity = new CreateUDBReplicationInstanceRequest(Config.region, mgDBId, "newmongo");
            var response = udb.CreateUDBReplicationInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateUDBSlaveTest()
        {
            var entity = new CreateUDBSlaveRequest(Config.region,dbid,"newslave");
            var response = udb.CreateUDBSlave(entity);
            Assert.AreEqual(response.RetCode, 0);
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
            var entity = new PromoteUDBSlaveRequest(Config.region,slaveId);
            var response = udb.PromoteUDBSlave(entity);
            Assert.AreEqual(response.RetCode, 0);
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
            #region 配置内容
            var config = @"[client]
 port = 3306
 socket = /tmp/mysql.sock
 [myisamchk]
 key_buffer_size = 20M
 read_buffer = 2M
 sort_buffer_size = 20M
 write_buffer = 2M
 [mysql]
 no-auto-rehash
 [mysqld]
 back_log = 2000
 basedir = /opt/udb/program/mysql/mysql-5.6.20
 bind-address = 10.4.4.168
 binlog-format = MIXED
 character_set_server = utf8
 datadir = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/data
 event_scheduler = ON
 expire_logs_days = 7
 general-log-file = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/log/mysqld.log
 innodb_buffer_pool_size = 629145600
 innodb_data_file_path = ibdata1:100M:autoextend
 innodb_data_home_dir = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/data
 innodb_file_per_table = 1
 innodb_flush_log_at_trx_commit = 2
 innodb_flush_method = O_DIRECT
 innodb_io_capacity = 2000
 innodb_log_buffer_size = 8388608
 innodb_log_file_size = 512M
 innodb_log_files_in_group = 2
 innodb_log_group_home_dir = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/data
 innodb_max_dirty_pages_pct = 50
 innodb_open_files = 1024
 innodb_read_io_threads = 8
 innodb_thread_concurrency = 20
 innodb_write_io_threads = 8
 key_buffer_size = 33554432
 local_infile = 0
 log-bin = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/binlog/mysql-bin.log
 log-error = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/log/mysqld.log
log_bin_trust_function_creators = 1
 log_output = TABLE
 long_query_time = 3
 max_allowed_packet = 16777216
 max_connect_errors = 1000000
 max_connections = 2000
 myisam_sort_buffer_size = 8388608
 net_buffer_length = 8192
 pid-file = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/mysqld.pid
 port = 3306
 query_cache_size = 16777216
 read_buffer_size = 262144
 read_rnd_buffer_size = 524288
 relay-log = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/relaylog/mysql-relay.log
 secure-file-priv = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/tmp
 server-id = 168035496
 skip-slave-start
 skip_name_resolve
 slave-load-tmpdir = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/tmp
 slow-query-log-file = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/log/mysql-slow.log
 slow_query_log = 1
 socket = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/mysqld.sock
 sort_buffer_size = 524288
 sync_binlog = 1
 table_open_cache = 128
 thread_cache_size = 50
 tmpdir = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/tmp
 user = mysql
 [mysqld_safe]
 log-error = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/log/mysqld.log
 pid-file = /opt/udb/instance/mysql-5.6/17e34f69-84df-4dfe-9318-4f5a5d824472/mysqld.pid
 [mysqldump]
 max_allowed_packet = 16M
 quick
 [mysqlhotcopy]
 interactive-timeout
 /opt/udb/instance/mysq";
            #endregion
            var entity = new UploadUDBParamGroupRequest(Config.region, "mysql-5.1", "ICYGMA", "icyuup", config);
            var response = udb.UploadUDBParamGroup(entity);
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
