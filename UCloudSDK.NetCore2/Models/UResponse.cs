namespace UCloudSDK.Models
{
    /// <summary>
    ///     返回结果
    /// </summary>
    public class UResponse
    {
        /// <summary>
        /// 执行结果代码
        ///     <para>
        ///     执行成功与否，0 表示成功，其他值则为错误代码.
        ///     </para>
        /// </summary>
        public int RetCode { get; set; }

        /// <summary>
        /// 错误消息.
        /// </summary>
        public string Message { get; set; }
    }
}