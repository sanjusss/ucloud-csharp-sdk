namespace UCloudSDK.Models
{
    /// <summary>
    /// 指定数据中心，根据资源使用量创建指定数量的UHost实例。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/create_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class CreateUHostInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "CreateUHostInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     CreateUHostInstance
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }  
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///      参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 镜像Id 
        ///     <para>
        ///      参见 DescribeImage
        ///     </para>                 
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 认证方式 
        ///     <para>
        ///     密码: Password，key: KeyPair（暂不支持）
        ///     </para>                 
        /// </summary>
        public string LoginMode { get; set; }

        /// <summary>
        /// UHost密码 
        /// </summary>
        private string _password;

        /// <summary>
        /// UHost密码 
        ///     <para>
        ///     LoginMode为Password时此项必须
        ///     </para>                 
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { _password = value.ToBase64(); }
        }

        /// <summary>
        /// Keyname 
        ///     <para>
        ///     LoginMode为KeyPair时此项必须（暂不支持）
        ///     </para>                 
        /// </summary>
        public string KeyPair { get; set; }

        /// <summary>
        /// 虚拟CPU核数 
        ///     <para>
        ///      单位：个，范围：[1,16],最小值为1，其他值是2的倍数， 默认值: 4
        ///     </para>                 
        /// </summary>
        public int? CPU { get; set; }

        /// <summary>
        /// 内存大小  
        ///     <para>
        ///      单位：MB范围[2048,65536]， 步长：2048， 默认值：8192
        ///     </para>                 
        /// </summary>
        public int? Memory { get; set; }

        /// <summary>
        /// 数据盘大小 
        ///     <para>
        ///      单位：GB， 范围[0,1000]，步长：10， 默认值：60
        ///     </para>                 
        /// </summary>
        public int? DiskSpace { get; set; }

        /// <summary>
        /// UHost实例名称 
        ///     <para>
        ///      默认：UHost
        ///     </para>                 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 网络Id 
        ///     <para>
        ///      默认：基础网络
        ///     </para>                 
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// 防火墙Id 
        ///     <para>
        ///      默认：Web防火墙
        ///     </para>                 
        /// </summary>
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 计费模式 
        ///     <para>
        ///     枚举值为：Year，按年付费；Month，按月付费；Dynamic，按需付费（需开启权限）；Trial，试用（需开启权限）默认为月付
        ///     </para>                 
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// 购买时长 
        ///     <para>
        ///     默认: 1
        ///     </para>                 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// 实例化 <see cref="CreateUHostInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="imageid">镜像Id</param>                    
        /// <param name="loginmode">认证方式</param>                    
        public CreateUHostInstanceRequest(string region, string imageid, string loginmode)
        {               
            Region = region;
            ImageId = imageid;
            LoginMode = loginmode;
        }                
    }
}
