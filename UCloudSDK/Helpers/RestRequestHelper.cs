using System;
using System.Linq;
using RestSharp;

namespace UCloudSDK
{
    /// <summary>
    /// RestRequest扩展方法
    /// </summary>
    public static class RestRequestHelper
    {

        /// <summary>
        /// 添加Ucloud对象.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static IRestRequest AddUObject(this IRestRequest request, object obj)
        {
            request.AddUObject(obj, new string[] { });
            return request;
        }

        /// <summary>
        /// 添加Ucloud对象.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="obj">The object.</param>
        /// <param name="includedProperties">The included properties.</param>
        /// <returns></returns>
        public static IRestRequest AddUObject(this IRestRequest request, object obj, params string[] includedProperties)
        {
            // automatically create parameters from object props
            var type = obj.GetType();
            var props = type.GetProperties();

            foreach (var prop in props)
            {
                bool isAllowed = includedProperties.Length == 0 ||
                                 (includedProperties.Length > 0 && includedProperties.Contains(prop.Name));

                if (!isAllowed)
                    continue;

                var propType = prop.PropertyType;
                var val = prop.GetValue(obj, null);

                if (val == null)
                    continue;

                if (propType.IsArray)
                {
                    var elementType = propType.GetElementType();

                    if (((Array)val).Length > 0 &&
                        elementType != null &&
                        (elementType.IsPrimitive || elementType.IsValueType || elementType == typeof(string)))
                    {
                        // convert the array to an array of strings
                        var values = (from object item in ((Array)val)
                                      select item.ToString())
                                     .ToArray<string>();

                        val = string.Join(",", values);
                    }
                    else
                    {
                        // try to cast it
                        val = string.Join(",", (string[])val);
                    }
                }

                if (propType.IsNlist())
                {
                    if (((NList)val).Count > 0)
                    {
                        // convert the array to an array of strings
                        var values = (from object item in ((NList)val)
                                      select item.ToString())
                                     .ToList();

                        for (int i = 0; i < values.Count; i++)
                        {
                            request.AddParameter(prop.Name + '.' + i, values[i]);
                        }
                    }
                    continue;
                }

                request.AddParameter(prop.Name, val);
            }

            return request;
        }
    }
}
