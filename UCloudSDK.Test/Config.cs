using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCloudSDK.Models;

namespace UCloudSDK.Test
{
    public static class Config
    {
        /// <summary>
        /// 公钥
        /// </summary>
        public static string PublicKey = "";
        /// <summary>
        /// 私钥
        /// </summary>
        public static string PrivateKey = "";
        /// <summary>
        /// 数据中心
        /// </summary>
        public static string region = Region.cn_north_03.ToString().ToHyphen();
        /// <summary>
        /// Bucket名称
        /// <para>
        /// 请修改为自己想设置的
        /// </para>
        /// </summary>
        public static string Bucket = "";
        /// <summary>
        /// UHost Id
        /// <para>
        /// 创建UHost实例后得到
        /// </para>
        /// </summary>
        public static string UhostId = "";
    }
}
