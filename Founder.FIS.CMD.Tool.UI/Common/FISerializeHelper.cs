/*----------------------------------------------------------------
// Copyright (C) 2014方正国际软件有限公司
// 版权所有。
// 文   件   名：FISerializeHelper
// 文件功能描述：序列号使用类
//
// 
// 创 建 人：Administrator
// 创建日期：2014/6/5 13:47:22
//
// 修 改 人：
// 修改描述：
//
// 修改标识：
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Founder.FIS.CMD.Tool.UI.Common
{
    public class FISerializeHelper
    {
        #region 字段


        #endregion

        #region 属性


        #endregion

        #region 构造方法


        #endregion

        #region 私有方法


        #endregion

        #region 公共方法

        /// <summary>
        /// 将对象序列化为string 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static string SerializeObjectToXmlString<T>(T entity)
        {
            //序列化过程
            StringBuilder buffer = new StringBuilder();
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StringWriter(buffer))
            {
                serializer.Serialize(writer, entity);
            }
            return buffer.ToString();
        }

        /// <summary>
        /// 将xml字符串反序列化为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static T DeXMLSerialize<T>(string xmlString)
        {
            T cloneObject = default(T);

            StringBuilder buffer = new StringBuilder();
            buffer.Append(xmlString);

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (TextReader reader = new StringReader(buffer.ToString()))
            {
                Object obj = serializer.Deserialize(reader);
                cloneObject = (T)obj;
            }

            return cloneObject;
        }


        /// <summary>
        /// 将对象序列化为string 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static string SerializeObjectToXmlString(object entity)
        {
            //序列化过程
            StringBuilder buffer = new StringBuilder();
            XmlSerializer serializer = new XmlSerializer(entity.GetType());
            using (TextWriter writer = new StringWriter(buffer))
            {
                serializer.Serialize(writer, entity);
            }
            return buffer.ToString();
        }

        /// <summary>
        /// 将xml字符串反序列化为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static object DeXMLSerialize(string xmlString, Type type)
        {
            object cloneObject;

            StringBuilder buffer = new StringBuilder();
            buffer.Append(xmlString);

            XmlSerializer serializer = new XmlSerializer(type);

            using (TextReader reader = new StringReader(buffer.ToString()))
            {
                Object obj = serializer.Deserialize(reader);
                cloneObject = obj;
            }

            return cloneObject;
        }  
        #endregion
    }
}
