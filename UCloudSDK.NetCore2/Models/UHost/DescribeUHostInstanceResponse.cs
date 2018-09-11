using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取主机或主机列表信息，并可根据数据中心，主机ID等参数进行过滤。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/describe_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class DescribeUHostInstanceResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///      DescribeUHostInstanceResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 满足条件的UHostInstance总数                
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// JSON格式的UHost实例列表 
        ///     <para>
        ///     每项参数可见下面ResponseItem
        ///     </para>                 
        /// </summary>
        public List<DescribeUHostInstanceUHostSet> UHostSet { get; set; }

    }
}
