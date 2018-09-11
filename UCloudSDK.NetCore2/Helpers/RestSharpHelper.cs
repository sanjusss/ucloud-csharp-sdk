using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace UCloudSDK
{
    /// <summary>
    /// RRestSharp扩展方法
    /// </summary>
    public static class RestSharpHelper
    {
        /// <summary>
        /// 获取Header值.
        /// </summary>
        /// <param name="parameters">参数.</param>
        /// <param name="key">Header名称.</param>
        /// <returns>Header值</returns>
        public static string GetHeader(this IList<Parameter> parameters, string key)
        {
            var param = parameters.FirstOrDefault(p => p.Type == ParameterType.HttpHeader && p.Name == key);
            return param != null ? param.Value.ToString() : string.Empty;
        }

        /// <summary>
        /// 生成标准化UCloud Header.
        /// </summary>
        /// <param name="parameters">参数.</param>
        /// <returns>CanonicalizedUCloudHeaders</returns>
        public static string CanonicalizedUCloudHeaders(this List<Parameter> parameters)
        {
            var header = parameters.Where(p => p.Type == ParameterType.HttpHeader);

            string canoncializedUCloudHeaders = string.Empty;

            var headerMap = new SortedDictionary<string, string>();

            foreach (var param in header.Where(p => p.Name.ToLower().StartsWith("x-ucloud-")))
            {
                string headerKey = param.Name;

                headerKey = headerKey.ToLower();
                if (headerMap.ContainsKey(headerKey))
                {
                    headerMap[headerKey] += @",";
                    headerMap[headerKey] += param.Value;
                }
                else
                {
                    headerMap.Add(headerKey, param.Value.ToString());
                }
            }

            foreach (var item in headerMap)
            {
                canoncializedUCloudHeaders += (item.Key + @":" + item.Value + @"\n");
            }
            return canoncializedUCloudHeaders;
        }

        /// <summary>
        /// 添加Ucloud对象.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="obj">The object.</param>
        /// <returns>IRestRequest对象</returns>
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
        /// <returns>IRestRequest对象</returns>
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

                var propName = prop.Name;

                if (propName.Contains("__"))
                {
                    propName = propName.Replace("__", "-");
                }

                request.AddParameter(propName, val);
            }

            return request;
        }
    }
}
