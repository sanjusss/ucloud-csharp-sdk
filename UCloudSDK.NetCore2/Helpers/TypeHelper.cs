using System;
using System.Collections.Generic;

namespace UCloudSDK
{
    /// <summary>
    /// Type扩展方法
    /// </summary>
    public static class TypeHelper
    {
        /// <summary>
        /// 判断是否为NList类型.
        ///     <para>
        ///         Params.n
        ///     </para>
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>Bool</returns>
        public static bool IsNlist(this Type type)
        {
            return type == typeof(NList);
        }
    }

    /// <summary>
    /// 自定义类型NList
    ///     <para>
    ///     用于Param.n样式的Array
    ///     </para>
    /// </summary>
    public class NList : List<string>
    {
    }
}
