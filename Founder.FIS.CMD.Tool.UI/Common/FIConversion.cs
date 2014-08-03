using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Reflection;
using System.Text;
using System.Web;
using System.Xml;

namespace Founder.FIS.CMD.Tool.UI.Common
{
    public static class FIConversion
    {
        #region 类型转换

        /// <summary>
        ///     Linq中IEnumerable转换成DataTable
        /// </summary>
        /// <param name="list"></param>
        /// <returns>DataTable</returns>
        public static DataTable ToDataTable(this IEnumerable list)
        {
            var dataTable = new DataTable();
            bool schemaIsBuild = false;
            PropertyInfo[] props = null;
            foreach (object item in list)
            {
                if (!schemaIsBuild)
                {
                    props =
                        item.GetType()
                            .GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty);
                    foreach (PropertyInfo pi in props)
                    {
                        dataTable.Columns.Add(new DataColumn(pi.Name, pi.PropertyType));
                    }
                    schemaIsBuild = true;
                }
                DataRow row = dataTable.NewRow();
                foreach (PropertyInfo pi in props)
                {
                    row[pi.Name] = pi.GetValue(item, null);
                }
                dataTable.Rows.Add(row);
            }
            dataTable.AcceptChanges();
            return dataTable;
        }

        /// <summary>
        ///     DataTable 转换为List 集合
        /// </summary>
        /// <typeparam name="TResult">类型</typeparam>
        /// <param name="dataTable">DataTable</param>
        /// <returns></returns>
        public static List<TResult> ToList<TResult>(this DataTable dataTable) where TResult : class, new()
        {
            //创建一个属性的列表
            var prlist = new List<PropertyInfo>();
            //获取TResult的类型实例  反射的入口
            Type t = typeof(TResult);
            //获得TResult 的所有的Public 属性 并找出TResult属性和DataTable的列名称相同的属性(PropertyInfo) 并加入到属性列表 
            Array.ForEach(t.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty),
                p => { if (dataTable.Columns.Contains(p.Name)) prlist.Add(p); });
            //创建返回的集合
            var oblist = new List<TResult>();
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    //创建TResult的实例
                    var ob = new TResult();
                    //找到对应的数据  并赋值
                    DataRow row1 = row;
                    prlist.ForEach(p => { if (row1[p.Name] != DBNull.Value) p.SetValue(ob, row1[p.Name], null); });
                    //放入到返回的集合中.
                    oblist.Add(ob);
                }
            }
            return oblist;
        }

        /// <summary>
        ///     值为1或true返回true，否则返回false
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean? ToBoolean(this String value)
        {
            if (value == null || String.IsNullOrEmpty(value.Trim()) || Equals(value.Trim().ToLower(), "system.object"))
                return null;
            if (Equals(value.Trim(), "1"))
                return true;
            else if (Equals(value.Trim().ToLower(), "true"))
                return true;
            else if (Equals(value.Trim(), "0"))
                return false;
            else if (Equals(value.Trim().ToLower(), "false"))
                return false;
            return null;
        }

        /// <summary>
        ///     值为1返回true其他返回false
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean? ToBoolean(this int value)
        {
            if (value == 1)
                return true;
            return ToBoolean(value.ToString());
        }

        /// <summary>
        ///     值为1或true返回true，否则返回false
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean? ToBoolean(this object value)
        {
            if (value == null || String.IsNullOrEmpty(value.ToString().Trim()))
                return null;
            return ToBoolean(value.ToString());
        }

        /// <summary>
        /// 转换为整型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt32(this object obj)
        {
            if (obj == null)
                return 0;
            if (Equals(obj, DBNull.Value))
                return 0;
            if (Equals(obj.ToString().ToLower().Trim(), "system.object"))
                return 0;
            if (Equals(obj.ToString().Trim(), String.Empty))
                return 0;
            int i;
            if (Int32.TryParse(obj.ToString(), out i))
            {
                return i;
            }
            return 0;
        }

        public static int ToInt32(this String obj)
        {
            if (String.IsNullOrEmpty(obj) || Equals(obj.Trim(), String.Empty))
                return 0;
            if (Equals(obj, DBNull.Value))
                return 0;
            if (String.IsNullOrEmpty(obj.Trim()))
                return 0;
            if (Equals(obj.ToLower().Trim(), "system.object"))
                return 0;
            int i;
            if (Int32.TryParse(obj.Trim(), out i))
            {
                return i;
            }
            return 0;
        }
        /// <summary>
        ///     object类型转化为string
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static String ToStringEx(this object obj)
        {
            if (obj == null || Equals(obj.ToString().ToLower().Trim(), "system.object"))
                return String.Empty;

            return obj.ToString().Trim();
        }

        /// <summary>
        ///     截取strFormer中长度为subLength的字符串，如果strFormer本身的长度小于subLength,返回strFormer
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="subLength"></param>
        /// <returns></returns>
        public static string ToSubString(this object obj, int subLength)
        {
            if (obj == null || Equals(obj.ToString().ToLower().Trim(), "system.object"))
                return String.Empty;

            if (obj.ToString().Trim().Length <= subLength)
                return obj.ToString().Trim();
            return obj.ToString().Trim().Substring(0, subLength) + "..";
            // return obj.ToString().Trim();
        }

        /// <summary>
        ///     转换为整型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int? ToInt(this object obj)
        {
            if (obj == null)
                return null;

            return ToInt(obj.ToString());
        }

        public static int? ToInt(this String obj)
        {
            if (String.IsNullOrEmpty(obj) || Equals(obj.Trim(), String.Empty))
                return null;
            int i;
            if (Int32.TryParse(obj.Trim(), out i))
            {
                return i;
            }
            return null;
        }

        public static int ToInt(this float obj)
        {
            return Convert.ToInt32(obj);
        }

        public static int ToInt(this double obj)
        {
            return Convert.ToInt32(obj);
        }

        public static int ToInt(this UInt32 obj)
        {
            return Convert.ToInt32(obj);
        }

        public static int ToInt(this long obj)
        {
            return Convert.ToInt32(obj);
        }

        public static int ToInt(this decimal obj)
        {
            return Convert.ToInt32(obj);
        }

        /// <summary>
        ///     转换为长整型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static long? ToLong(this object obj)
        {
            if (obj == null)
                return null;

            return ToLong(obj);
        }

        public static long? ToLong(this String obj)
        {
            if (obj == null)
                return null;

            long i;
            if (Int64.TryParse(obj, out i))
            {
                return i;
            }
            return null;
        }

        public static long ToLong(this int obj)
        {
            return Convert.ToInt64(obj);
        }

        public static long ToLong(this float obj)
        {
            return Convert.ToInt64(obj);
        }

        public static long ToLong(this double obj)
        {
            return Convert.ToInt64(obj);
        }

        public static long ToLong(this UInt32 obj)
        {
            return Convert.ToInt64(obj);
        }

        /// <summary>
        ///     转换为浮点型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static float ToFloat(this object obj)
        {
            if (obj == null)
                return 0;
            if (Equals(obj.ToString(), String.Empty))
                return 0;
            if (Equals(obj, DBNull.Value))
                return 0;
            if (Equals(obj.ToString().ToLower().Trim(), "system.object"))
                return 0;
            float i;
            if (float.TryParse(obj.ToString(), out i))
            {
                return i;
            }
            return 0;
        }

        public static float ToFloat(this String obj)
        {
            if (obj == null)
                return 0;
            if (Equals(obj.Trim(), String.Empty))
                return 0;
            if (Equals(obj, DBNull.Value))
                return 0;
            if (Equals(obj.ToLower().Trim(), "system.object"))
                return 0;
            float i;
            if (float.TryParse(obj, out i))
            {
                return i;
            }
            return 0;
        }

        public static float ToFloat(this int obj)
        {
            return Convert.ToInt64(obj);
        }

        public static float ToFloat(this double obj)
        {
            return Convert.ToInt64(obj);
        }

        public static float ToFloat(this UInt32 obj)
        {
            return Convert.ToInt64(obj);
        }

        public static long ToFloat(this long obj)
        {
            return Convert.ToInt64(obj);
        }

        /// <summary>
        ///     转换为高精度型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this object obj)
        {
            if (obj == null)
                return 0;
            if (obj == DBNull.Value)
                return 0;
            if (obj.ToString().ToLower().Trim() == "system.object")
                return 0;
            if (String.IsNullOrEmpty(obj.ToString().Trim()))
                return 0;
            decimal i;
            if (decimal.TryParse(obj.ToString(), out i))
            {
                return i;
            }
            return 0;
        }

        /// <summary>
        ///     转化成double类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double ToDouble(this object obj)
        {
            if (obj == null)
                return 0;
            if (obj == DBNull.Value)
                return 0;
            if (obj.ToString().ToLower().Trim() == "system.object")
                return 0;
            if (String.IsNullOrEmpty(obj.ToString().Trim()))
                return 0;
            double i;
            if (double.TryParse(obj.ToString(), out i))
            {
                return i;
            }
            return 0;
        }

        /// <summary>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double ToDouble(this String obj)
        {
            if (obj == null)
                return 0;
            if (String.IsNullOrEmpty(obj))
                return 0;
            if (obj.ToLower().Trim() == "system.object")
                return 0;
            if (String.IsNullOrEmpty(obj.Trim()))
                return 0;
            double i;
            if (double.TryParse(obj, out i))
            {
                return i;
            }
            return 0;
        }

        /// <summary>
        ///     转换为高精度型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this String obj)
        {
            if (obj == null)
                return 0;
            if (String.IsNullOrEmpty(obj.Trim()))
                return 0;
            if (obj.ToLower().Trim() == "system.object")
                return 0;
            decimal i;
            if (decimal.TryParse(obj, out i))
            {
                return i;
            }
            return 0;
        }


        /// <summary>
        ///     日期转字符
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>如果日期是1753/01/01 00:00:00（数据库最小时间）则返回空字符串；其他情况返回yyyy-MM-dd格式日期字符串</returns>
        public static String ToDateString(this object obj)
        {
            if (SqlDateTime.MinValue.Value == obj.ToDateTime() || DateTime.MinValue == obj.ToDateTime())
            {
                return string.Empty;
            }
            return obj.ToDateTime().ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 日期转字符带时间
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>如果日期是1753/01/01 00:00:00（数据库最小时间）则返回空字符串；
        /// 其他情况返回yyyy-MM-dd HH:mm:ss格式日期字符串</returns>
        public static String ToDateTimeString(this object obj)
        {
            if (SqlDateTime.MinValue.Value == obj.ToDateTime() || DateTime.MinValue == obj.ToDateTime())
            {
                return string.Empty;
            }
            return obj.ToDateTime().ToString("yyyy-MM-dd HH:mm:ss");
        }
        /// <summary>
        ///     日期转字符
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>如果日期是1753/01/01 00:00:00（数据库最小时间）则返回空字符串；其他情况返回yyyy-MM-dd格式日期字符串</returns>
        public static String ToDateString(this DateTime obj)
        {
            if (SqlDateTime.MinValue.Value == obj || DateTime.MinValue == obj)
            {
                return string.Empty;
            }
            return obj.ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 日期转字符带时间
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>如果日期是1753/01/01 00:00:00（数据库最小时间）则返回空字符串；
        /// 其他情况返回yyyy-MM-dd HH:mm:ss格式日期字符串</returns>
        public static String ToYearMonthDateString(this object obj)
        {
            if (SqlDateTime.MinValue.Value == obj.ToDateTime() || DateTime.MinValue == obj.ToDateTime())
            {
                return string.Empty;
            }
            return obj.ToDateTime().ToString("yyyy-MM");
        }
        /// <summary>
        ///     日期转字符
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>如果日期是1753/01/01 00:00:00（数据库最小时间）则返回空字符串；其他情况返回yyyy-MM-dd格式日期字符串</returns>
        public static String ToYearMonthDateString(this DateTime obj)
        {
            if (SqlDateTime.MinValue.Value == obj || DateTime.MinValue == obj)
            {
                return string.Empty;
            }
            return obj.ToString("yyyy-MM");
        }

        /// <summary>
        ///     转换为日期型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>转换失败是返回1753/01/01 00:00:00（数据库最小时间）</returns>
        public static DateTime ToDateTime(this object obj)
        {
            if (obj == null)
                return SqlDateTime.MinValue.Value;
            if (obj == DBNull.Value)
                return SqlDateTime.MinValue.Value;
            if (obj.ToString().ToLower().Trim() == "system.object")
                return SqlDateTime.MinValue.Value;
            if (String.IsNullOrEmpty(obj.ToString().Trim()))
                return SqlDateTime.MinValue.Value;
            DateTime i;
            if (DateTime.TryParse(obj.ToString(), out i))
            {
                return i;
            }
            return SqlDateTime.MinValue.Value;
        }

        /// <summary>
        ///     转换为日期型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>如果是1753/01/01 00:00:00（数据库最小时间），则返回空值</returns>
        public static DateTime? ToDateTime(this DateTime obj)
        {
            if (obj == SqlDateTime.MinValue.Value)
                return null;
            return obj;
        }

        /// <summary>
        ///     转换为日期型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>转换失败是返回1753/01/01 00:00:00（数据库最小时间）</returns>
        public static DateTime ToDateTime(this String obj)
        {
            if (obj == null)
                return SqlDateTime.MinValue.Value;
            if (String.IsNullOrEmpty(obj.Trim()))
                return SqlDateTime.MinValue.Value;
            if (obj.ToLower().Trim() == "system.object")
                return SqlDateTime.MinValue.Value;
            DateTime i;
            if (DateTime.TryParse(obj, out i))
            {
                return i;
            }
            return SqlDateTime.MinValue.Value;
        }


        public static decimal ToDecimal(this int obj)
        {
            return Convert.ToDecimal(obj);
        }

        public static decimal ToDecimal(this float obj)
        {
            return Convert.ToDecimal(obj);
        }

        public static decimal ToDecimal(this double obj)
        {
            return Convert.ToDecimal(obj);
        }

        public static decimal ToDecimal(this UInt32 obj)
        {
            return Convert.ToDecimal(obj);
        }

        public static decimal ToDecimal(this long obj)
        {
            return Convert.ToDecimal(obj);
        }

        public static double ToDouble(this int obj)
        {
            return Convert.ToDouble(obj);
        }

        public static double ToDouble(this float obj)
        {
            return Convert.ToDouble(obj);
        }

        public static double ToDouble(this UInt32 obj)
        {
            return Convert.ToDouble(obj);
        }

        public static double ToDouble(this long obj)
        {
            return Convert.ToDouble(obj);
        }

        /// <summary>
        ///     保留四位小数
        /// </summary>
        /// <param name="dblData"></param>
        /// <returns></returns>
        public static string ToFormartNumerSixData(object dblData)
        {
            return String.Format("{0:N6}", dblData);
        }

        /// <summary>
        ///     保留四位小数
        /// </summary>
        /// <param name="dblData"></param>
        /// <returns></returns>
        public static string ToFormartNumerFourData(object dblData)
        {
            return String.Format("{0:N4}", dblData);
        }


        /// <summary>
        ///     保留两位小数
        /// </summary>
        /// <param name="dblData"></param>
        /// <returns></returns>
        public static string ToFormartNumerTwoDataValue(object dblData)
        {
            return String.Format("{0:N2}", dblData);
        }


        /**/

        /// <summary>
        ///     将Xml内容字符串转换成DataSet对象
        /// </summary>
        /// <param name="xmlStr">Xml内容字符串</param>
        /// <returns>DataSet对象</returns>
        public static DataSet CXmlToDataSet(String xmlStr)
        {
            if (!String.IsNullOrEmpty(xmlStr))
            {
                var ds = new DataSet();
                //读取字符串中的信息
                using (var strStream = new StringReader(xmlStr))
                {
                    using (var xmlrdr = new XmlTextReader(strStream))
                    {
                        ds.ReadXml(xmlrdr);
                    }
                }
                return ds;
            }
            return null;
        }

        /**/

        /// <summary>
        ///     将Xml字符串转换成DataTable对象
        /// </summary>
        /// <param name="xmlStr">Xml字符串</param>
        /// <param name="tableIndex">Table表索引</param>
        /// <returns>DataTable对象</returns>
        public static DataTable CXmlToDataTable(String xmlStr, int tableIndex)
        {
            return CXmlToDataSet(xmlStr).Tables[tableIndex];
        }

        /**/

        /// <summary>
        ///     将Xml字符串转换成DataTable对象
        /// </summary>
        /// <param name="xmlStr">Xml字符串</param>
        /// <returns>DataTable对象</returns>
        public static DataTable XMLToDataTable(String xmlStr)
        {
            return CXmlToDataSet(xmlStr).Tables[0];
        }

        /**/

        /// <summary>
        ///     读取Xml文件信息,并转换成DataSet对象
        /// </summary>
        /// <remarks>
        ///     DataSet ds = new DataSet();
        ///     ds = CXmlFileToDataSet("/XML/upload.xml");
        /// </remarks>
        /// <param name="xmlFilePath">Xml文件地址</param>
        /// <returns>DataSet对象</returns>
        public static DataSet XMLToDataSetFromFile(String xmlFilePath)
        {
            if (!String.IsNullOrEmpty(xmlFilePath))
            {
                String path = xmlFilePath;

                var xmldoc = new XmlDocument();
                //根据地址加载Xml文件
                xmldoc.Load(path);

                var ds = new DataSet();
                //读取文件中的字符流
                using (var strStream = new StringReader(xmldoc.InnerXml))
                {
                    using (var xmlrdr = new XmlTextReader(strStream))
                    {
                        ds.ReadXml(xmlrdr);
                    }
                }
                return ds;
            }
            return null;
        }

        /**/

        /// <summary>
        ///     读取Xml文件信息,并转换成DataTable对象
        /// </summary>
        /// <param name="xmlFilePath">xml文江路径</param>
        /// <param name="tableIndex">Table索引</param>
        /// <returns>DataTable对象</returns>
        public static DataTable XMLToDataTableFromFile(String xmlFilePath, int tableIndex)
        {
            return XMLToDataSetFromFile(xmlFilePath).Tables[tableIndex];
        }

        /**/

        /// <summary>
        ///     读取Xml文件信息,并转换成DataTable对象
        /// </summary>
        /// <param name="xmlFilePath">xml文江路径</param>
        /// <returns>DataTable对象</returns>
        public static DataTable XMLToDataTableFromFile(String xmlFilePath)
        {
            return XMLToDataSetFromFile(xmlFilePath).Tables[0];
        }

        public static string ToJson(this List<string> dtlist)
        {
            if (dtlist == null || dtlist.Count == 0)
            {
                return "[]";
            }

            var jsonBuilder = new StringBuilder();
            jsonBuilder.Append("[");
            foreach (string s in dtlist)
            {
                jsonBuilder.Append("\"" + s + "\"");
                jsonBuilder.Append(",");
            }
            jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("];");
            return jsonBuilder.ToString();
        }

        #region  数据转换成xml

        /**/

        /// <summary>
        ///     将DataTable对象转换成XML字符串
        /// </summary>
        /// <param name="dt">DataTable对象</param>
        /// <returns>XML字符串</returns>
        public static String CDataToXml(DataTable dt)
        {
            if (dt != null)
            {
                byte[] temp;
                using (var ms = new MemoryStream())
                {
                    using (var xmlWt = new XmlTextWriter(ms, Encoding.Unicode))
                    {
                        dt.WriteXml(xmlWt);
                    }
                    var count = (int)ms.Length;
                    temp = new byte[count];
                    ms.Seek(0, SeekOrigin.Begin);
                    ms.Read(temp, 0, count);
                }
                //返回Unicode编码的文本
                var ucode = new UnicodeEncoding();
                String returnValue = ucode.GetString(temp).Trim();
                return returnValue;
            }
            return String.Empty;
        }

        /**/

        /// <summary>
        ///     将DataSet对象中指定的Table转换成XML字符串
        /// </summary>
        /// <param name="ds">DataSet对象</param>
        /// <param name="tableIndex">DataSet对象中的Table索引</param>
        /// <returns>XML字符串</returns>
        public static String CDataToXml(DataSet ds, int tableIndex)
        {
            if (ds != null && ds.Tables != null)
            {
                if (tableIndex != -1 && ds.Tables.Count >= tableIndex)
                {
                    return CDataToXml(ds.Tables[tableIndex]);
                }
                if (ds.Tables.Count > 0)
                {
                    return CDataToXml(ds.Tables[0]);
                }
            }
            return String.Empty;
        }

        /**/

        /// <summary>
        ///     将DataSet对象转换成XML字符串
        /// </summary>
        /// <param name="ds">DataSet对象</param>
        /// <returns>XML字符串</returns>
        public static String CDataToXml(DataSet ds)
        {
            return CDataToXml(ds, -1);
        }

        /**/

        /// <summary>
        ///     将DataView对象转换成XML字符串
        /// </summary>
        /// <param name="dv">DataView对象</param>
        /// <returns>XML字符串</returns>
        public static String CDataToXml(DataView dv)
        {
            return CDataToXml(dv.Table);
        }

        /**/

        /// <summary>
        ///     将DataSet对象数据保存为XML文件
        /// </summary>
        /// <param name="dt">DataSet</param>
        /// <param name="xmlFilePath">XML文件路径(相对路径)</param>
        /// <returns>bool值</returns>
        public static bool CDataToXmlFile(DataTable dt, String xmlFilePath)
        {
            if ((dt != null) && (!String.IsNullOrEmpty(xmlFilePath)))
            {
                String path = xmlFilePath;//HttpContext.Current.Server.MapPath(xmlFilePath);

                byte[] temp;
                using (var ms = new MemoryStream())
                {
                    using (var xmlWt = new XmlTextWriter(ms, Encoding.Unicode))
                    {
                        dt.WriteXml(xmlWt);
                    }
                    var count = (int)ms.Length;
                    temp = new byte[count];
                    ms.Seek(0, SeekOrigin.Begin);
                    ms.Read(temp, 0, count);
                }
                //返回Unicode编码的文本
                var ucode = new UnicodeEncoding();
                //写文件
                using (var sw = new StreamWriter(path))
                {
                    sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    sw.WriteLine(ucode.GetString(temp).Trim());
                    sw.Close();
                }
                return true;
            }
            return false;
        }

        /**/

        /// <summary>
        ///     将DataSet对象中指定的Table转换成XML文件
        /// </summary>
        /// <param name="ds">DataSet对象</param>
        /// <param name="tableIndex">DataSet对象中的Table索引</param>
        /// <param name="xmlFilePath">xml文件路径</param>
        /// <returns>bool]值</returns>
        public static bool CDataToXmlFile(DataSet ds, int tableIndex, String xmlFilePath)
        {
            if (tableIndex != -1)
            {
                return CDataToXmlFile(ds.Tables[tableIndex], xmlFilePath);
            }
            return CDataToXmlFile(ds.Tables[0], xmlFilePath);
        }

        /**/

        /// <summary>
        ///     将DataSet对象转换成XML文件
        /// </summary>
        /// <param name="ds">DataSet对象</param>
        /// <param name="xmlFilePath">xml文件路径</param>
        /// <returns>bool]值</returns>
        public static bool CDataToXmlFile(DataSet ds, String xmlFilePath)
        {
            return CDataToXmlFile(ds, -1, xmlFilePath);
        }

        /**/

        /// <summary>
        ///     将DataView对象转换成XML文件
        /// </summary>
        /// <param name="dv">DataView对象</param>
        /// <param name="xmlFilePath">xml文件路径</param>
        /// <returns>bool]值</returns>
        public static bool CDataToXmlFile(DataView dv, String xmlFilePath)
        {
            return CDataToXmlFile(dv.Table, xmlFilePath);
        }

        #endregion

        #region String

        /// <summary>
        ///     日期型默认值
        /// </summary>
        public static readonly DateTime DateTimeDefaultValue = new DateTime(1900, 1, 1);

        /// <summary>
        ///     字符串型默认值
        /// </summary>
        public static readonly String StringDefaultValue = String.Empty;

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(string inputValue)
        {
            if ((inputValue == null) || inputValue == String.Empty)
            {
                return "";
            }
            return inputValue;
        }

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(DateTime inputValue)
        {
            if (inputValue <= DateTimeDefaultValue)
            {
                return inputValue.ToString();
            }
            return "";
        }

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(short inputValue)
        {
            return inputValue.ToString();
        }

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(int inputValue)
        {
            return inputValue.ToString();
        }

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(long inputValue)
        {
            return inputValue.ToString();
        }

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(decimal inputValue)
        {
            return inputValue.ToString();
        }

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(float inputValue)
        {
            return inputValue.ToString();
        }

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(double inputValue)
        {
            return inputValue.ToString();
        }

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(bool inputValue)
        {
            return inputValue.ToString();
        }

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(object inputValue)
        {
            try
            {
                if (inputValue == null || inputValue == DBNull.Value)
                {
                    return "";
                }
                return ToString(inputValue.ToString());
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        ///     将枚举项转换为String类型(返回枚举索引值)
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(Enum inputValue)
        {
            return ToString(ToInt(inputValue));
        }

        /// <summary>
        ///     将char数组转换为String类型
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string ToString(char[] inputValue)
        {
            try
            {
                var str = new StringBuilder();
                foreach (char c in inputValue)
                {
                    str.Append(c.ToString());
                }
                return str.ToString();
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        ///     转换为String
        /// </summary>
        /// <param name="inputValue"></param>
        /// <param name="formatString"></param>
        /// <returns></returns>
        public static string ToString(DateTime inputValue, string formatString)
        {
            if (inputValue <= DateTimeDefaultValue)
            {
                return inputValue.ToString(formatString);
            }
            return "";
        }

        /// <summary>
        /// 将空的字符串转换为空的GUID形式
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static String ToStringGuid(this object obj)
        {
            if (obj == null || Equals(obj.ToString().ToLower().Trim(), "system.object"))
                return Guid.Empty.ToString();

            return obj.ToString().Trim();
        }

        /// <summary>
        /// 将空的字符串转换为空的GUID形式
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Guid? ToGuid(this String obj)
        {
            Guid guid;
            if (obj == null || obj == "" || Equals(obj.ToString().ToLower().Trim(), "system.object"))
                return null;
            if (Guid.TryParse(obj, out guid))
            {
                return guid;
            }
            return null;
        }
        /// <summary>
        /// 将空的字符串转换为空的GUID形式
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Guid? ToGuid(this Object obj)
        {
            Guid guid;
            if (obj == null || obj == "" || Equals(obj.ToString().ToLower().Trim(), "system.object"))
                return null;
            if (Guid.TryParse(obj.ToString(), out guid))
            {
                return guid;
            }
            return null;
        }

        #endregion

        #region 枚举

        /// <summary>
        ///  转换成枚举
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TEnum ToEnum<TEnum>(this string value) where TEnum : struct
        {
            TEnum tEnum;
            Enum.TryParse(value, out tEnum);
            return tEnum;
        }
        /// <summary>
        ///  转换成枚举
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TEnum ToEnum<TEnum>(this int value) where TEnum : struct
        {
            TEnum tEnum;
            Enum.TryParse(value.ToStringEx(), out tEnum);
            return tEnum;
        }
        /// <summary>
        /// 获取枚举值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToEnumValue<T>(this string name)
        {
            return (int)Enum.Parse(typeof(T), name, true);
        }

        /// <summary>
        /// 获取枚举值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToEnumValue(this Enum value)
        {
            string name = Enum.GetName(value.GetType(), value);
            Type type = value.GetType();
            //return (int)Enum.Parse(type, name, true);
            int returnValue = name == null ? int.Parse(value.ToString()) : 0;
            try
            {
                returnValue = (int)Enum.Parse(type, name, true);
            }
            catch (Exception)
            {

            }
            return returnValue;
        }
        #endregion
        #endregion
    }
}