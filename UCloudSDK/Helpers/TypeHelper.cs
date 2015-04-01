﻿using System;

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
        /// <returns></returns>
        public static bool IsNlist(this Type type)
        {
            return type == typeof(NList);
        }
    }
}
