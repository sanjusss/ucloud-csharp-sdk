using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 显示SSL证书信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/describe_ssl.html
    ///     </para>
    /// </summary>
    public partial class DescribeSSLResponse : UResponse
    {
        /// <summary>
        /// 响应动作 
        ///     <para>
        ///     BindSSLResponse
        ///     </para>                 
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 满足条件的SSL证书总数                
        /// </summary>
        public string TotalCOunt { get; set; }

        /// <summary>
        /// SSL证书详细信息 
        ///     <para>
        ///     具体结构见DataSet
        ///     </para>                 
        /// </summary>
        public List<DescribeSSLDataSet> DataSet { get; set; }

    }
}
