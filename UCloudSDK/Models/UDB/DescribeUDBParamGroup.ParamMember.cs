namespace UCloudSDK.Models
{
    /// <summary>
    /// 获取参数组详细参数信息
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/describe_udb_param_group.html
    ///     </para>
    /// </summary>
    public partial class DescribeUDBParamGroupParamMember
    {
        /// <summary>
        /// 参数名称                
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 参数值                
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 参数值应用类型 
        ///     <para>
        ///     包括0-unknown、10-int、20-string、30-bool
        ///     </para>                 
        /// </summary>
        public int ValueType { get; set; }

        /// <summary>
        /// 允许的值(根据参数类型 
        ///     <para>
        ///     用分隔符表示)
        ///     </para>                 
        /// </summary>
        public string AllowedVal { get; set; }

        /// <summary>
        /// 参数值应用类型 
        ///     <para>
        ///     包括0-unknown、10-static、20-dynamic
        ///     </para>                 
        /// </summary>
        public int ApplyType { get; set; }

        /// <summary>
        /// 是否可更改 
        ///     <para>
        ///     默认为false
        ///     </para>                 
        /// </summary>
        public bool Modifiable { get; set; }

        /// <summary>
        /// 允许值得格式类型 
        ///     <para>
        ///     包括PVFT_UNKOWN=0,PVFT_RANGE=10, PVFT_ENUM=20
        ///     </para>                 
        /// </summary>
        public int FormatType { get; set; }

    }
}
