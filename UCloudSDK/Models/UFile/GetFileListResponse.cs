using System.Collections.Generic;

namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取Bucket的文件列表
    ///     <para>
    ///     http://docs.ucloud.cn/api/ufile/get_file_list.html
    ///     </para>
    /// </summary>
    public partial class GetFileListResponse : UResponse
    {
        /// <summary>
        /// 动作响应                
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Bucket下的文件列表                
        /// </summary>
        public List<GetFileListDataSet> DataSet { get; set; }

    }
}
