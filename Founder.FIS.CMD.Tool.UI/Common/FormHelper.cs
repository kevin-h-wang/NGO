using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Founder.FIS.CMD.Tool.Common;

namespace Founder.FIS.CMD.Tool.UI.Common
{
    /// <summary>
    /// 帮助类
    /// </summary>
    public class FormHelper
    {
        /// <summary>
        /// 枚举填充到 ListItem 
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="isAddSelected">是否添加请选择</param>
        /// <returns>ListItem集合</returns>
        public static List<ListItem> GetListViaEnum(Type enumType, bool isAddSelected = true)
        {
            Array values = Enum.GetValues(enumType);
            var listItems = new List<ListItem>();
            if (isAddSelected)
            {
                listItems.Add(new ListItem("--请选择--", -1));
            }
            for (int i = 0; i < values.Length; i++)
            {
                string text = values.GetValue(i).ToString();
                var value = (int)values.GetValue(i);
                listItems.Add(new ListItem(text, value.ToString(CultureInfo.InvariantCulture)));
            }
            return listItems;
        }

        /// <summary>
        /// 根据数据库类型获取C#类型
        /// </summary>
        /// <returns></returns>
        public static string GetCSharpTypeByDBType(CMD2DBType dbType)
        {
            string cSharpType = "";
            switch (dbType)
            {
                case CMD2DBType.UDT_BigInt:
                    cSharpType = "long";
                    break;
                case CMD2DBType.UDT_Bit:
                    cSharpType = "bool";
                    break;
                case CMD2DBType.UDT_Nvarchar_100:
                case CMD2DBType.UDT_Nvarchar_400:
                case CMD2DBType.UDT_Nvarchar_1000:
                case CMD2DBType.UDT_Nvarchar_max:
                    cSharpType = "string";
                    break;
                case CMD2DBType.UDT_DateTime:
                    cSharpType = "DateTime";
                    break;
                case CMD2DBType.UDT_Numeric_24_2:
                case CMD2DBType.UDT_Numeric_24_4:
                case CMD2DBType.UDT_Numeric_24_6:
                    cSharpType = "decimal";
                    break;
                case CMD2DBType.UDT_Int:
                    cSharpType = "int";
                    break;
                case CMD2DBType.UDT_Guid:
                    cSharpType = "Guid";
                    break;
                case CMD2DBType.UDT_Varbinary_max:
                    cSharpType = "byte[]";
                    break;
                default:
                    cSharpType = "string";
                    break;
            }
            return cSharpType;
        }

        /// <summary>
        /// 将字符串转换为CMD2DBType枚举类型
        /// </summary>
        /// <param name="strType">类型</param>
        /// <returns></returns>
        public static CMD2DBType ConvertStrToCMD2DBType(string strType)
        {
            CMD2DBType cmd2DBType = CMD2DBType.Error;
            switch (strType)
            {
                case "UDT_BigInt":
                    cmd2DBType = CMD2DBType.UDT_BigInt;
                    break;
                case "UDT_Bit":
                    cmd2DBType = CMD2DBType.UDT_Bit;
                    break;
                case "UDT_DateTime":
                    cmd2DBType = CMD2DBType.UDT_DateTime;
                    break;
                case "UDT_Guid":
                    cmd2DBType = CMD2DBType.UDT_Guid;
                    break;
                case "UDT_Int":
                    cmd2DBType = CMD2DBType.UDT_Int;
                    break;
                case "UDT_Numeric(24,2)":
                    cmd2DBType = CMD2DBType.UDT_Numeric_24_2;
                    break;
                case "UDT_Numeric(24,4)":
                    cmd2DBType = CMD2DBType.UDT_Numeric_24_4;
                    break;
                case "UDT_Numeric(24,6)":
                    cmd2DBType = CMD2DBType.UDT_Numeric_24_6;
                    break;
                case "UDT_Nvarchar(100)":
                    cmd2DBType = CMD2DBType.UDT_Nvarchar_100;
                    break;
                case "UDT_Nvarchar(400)":
                    cmd2DBType = CMD2DBType.UDT_Nvarchar_400;
                    break;
                case "UDT_Nvarchar(1000)":
                    cmd2DBType = CMD2DBType.UDT_Nvarchar_1000;
                    break;
                case "UDT_Nvarchar(max)":
                    cmd2DBType = CMD2DBType.UDT_Nvarchar_max;
                    break;
                case "UDT_Varbinary(max)":
                    cmd2DBType = CMD2DBType.UDT_Varbinary_max;
                    break;
                default:
                    cmd2DBType = CMD2DBType.Error;
                    break;
            }
            return cmd2DBType;
        }


        /// <summary>
        /// 根据类型获取转换方法
        /// </summary>
        /// <returns></returns>
        public static string GetConvertMethodByType(string type)
        {
            string cSharpType = "";
            switch (type)
            {
                case "long":
                    cSharpType = ".ToInt64()";
                    break;
                case "bool":
                    cSharpType = ".ToBoolean()";
                    break;
                case "DateTime":
                    cSharpType = ".ToDateTime()";
                    break;
                case "Guid":
                    cSharpType = ".ToGuid()";
                    break;
                case "int":
                    cSharpType = ".ToInt32()";
                    break;
                case "decimal":
                    cSharpType = ".ToDecimal()";
                    break;
                case "string":
                    cSharpType = "";
                    break;
                case "Byte[]":
                    cSharpType = "";
                    break;
                default:
                    cSharpType = "";
                    break;
            }
            return cSharpType;
        }

        /// <summary>
        /// 根据控件类型获取控件属性值的设置属性
        /// </summary>
        /// <param name="controlType"></param>
        /// <returns></returns>
        public static string GetControlPropertyValueSetProperty(EnumControlType controlType)
        {
            string strReturnValue = string.Empty;
            switch (controlType)
            {
                case EnumControlType.FIDropDownList:
                case EnumControlType.FIEditableDropDownList:
                case EnumControlType.FIEditableDropDownListEx:
                    strReturnValue = "SelectedValue";
                    break;
                default:
                    strReturnValue = "Text";
                    break;
            }
            return strReturnValue;
        }

        /// <summary>
        /// 根据类型获取Aligment
        /// </summary>
        /// <returns></returns>
        public static string GetAligmentByType(string type)
        {
            string aligment = "";
            switch (type)
            {
                case "long":
                case "bool":
                case "DateTime":
                case "int":
                case "decimal":
                case "byte[]":
                    aligment = "Right";
                    break;
                case "Guid":
                case "string":
                    aligment = "Left";
                    break;
                default:
                    aligment = "Left";
                    break;
            }
            return aligment;
        }


        /// <summary>
        /// 更新配置文件节点
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">值</param>
        public static void SaveConfigKey(string key, string value)
        {
            bool isUpdate = false;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (value != config.AppSettings.Settings[key].Value)
            {
                config.AppSettings.Settings[key].Value = value;
                isUpdate = true;
            }
            if (isUpdate)
            {
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        /// <summary>
        /// 判断类型是否是可空的类型
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns>是否可空，如果是，则返回true,否则返回false</returns>
        public static bool IsNullableType(string type)
        {
            if (type.Equals("long") ||
                type.Equals("bool") ||
                type.Equals("DateTime") ||
                type.Equals("decimal") ||
                type.Equals("int") ||
                type.Equals("Guid"))
            {
                return true;
            }
            return false;
        }
    }
}
