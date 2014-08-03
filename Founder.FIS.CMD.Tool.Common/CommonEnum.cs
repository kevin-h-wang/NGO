using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.Common
{
    public enum EnumDatabaseType
    {
        Oracle = 1,
        SQLServer = 2,
        DB2 = 3,
        MySql = 4
    }

    public enum EnumControlType
    {
        无 = -1,
        FIButton = 1,
        FIDatePicker = 2,
        FICheckBox = 3,
        FICheckBoxList = 4,
        FIDropDownList = 5,
        FIDropDownCheckListEx = 6,
        FIEditableDropDownList = 7,
        FIEditableDropDownListEx = 8,
        FIHiddenField = 9,
        FIHyperLink = 10,
        FIImageButton = 11,
        FILabel = 12,
        FILiteral = 13,
        FILinkButton = 14,
        FIRadioButton = 15,
        FIRadioButtonList = 16,
        FITextBox = 17,
        FINumberTextBox = 18,
        FIEmailTextBox = 19,
        FIAutoCompleteTextBox = 20,
        FIAutoCompleteTextBoxEx = 21,
        FIAutoTextArea = 22,
        FIFileUpload = 23,
        FIRepeater = 24
    }

    public enum EnumValidateType
    {
        无 = -1,
        必填 = 1,
        必填数字 = 2,
        必填邮箱 = 3
    }

    public enum EnumFilterType
    {
        编辑页面 = 1,
        列表页面 = 2,
        查询条件 = 3
    }

    /// <summary>
    /// CMD2.0数据库类型
    /// </summary>
    public enum CMD2DBType
    {
        /// <summary>
        /// 自定义数据类型，对应bigint
        /// </summary>
        UDT_BigInt = 1,

        /// <summary>
        /// 自定义数据类型，对应bit
        /// </summary>
        UDT_Bit = 2,

        /// <summary>
        /// 自定义数据类型，对应datetime
        /// </summary>
        UDT_DateTime = 3,

        /// <summary>
        /// /// <summary>
        /// 自定义数据类型，对应uniqueIdentifier
        /// </summary>
        UDT_Guid = 4,

        /// <summary>
        /// /// <summary>
        /// 自定义数据类型，对应int
        /// </summary>
        UDT_Int = 5,

        /// <summary>
        /// /// <summary>
        /// 自定义数据类型，对应numeric(24,2)
        /// </summary>
        UDT_Numeric_24_2 = 6,

        /// <summary>
        /// /// <summary>
        /// 自定义数据类型，对应numeric(24,4)
        /// </summary>
        UDT_Numeric_24_4 = 7,

        /// <summary>
        /// /// <summary>
        /// 自定义数据类型，对应numeric(24,6)
        /// </summary>
        UDT_Numeric_24_6 = 8,

        /// <summary>
        /// /// <summary>
        /// 自定义数据类型，对应nvarchar(100)
        /// </summary>
        UDT_Nvarchar_100 = 9,

        /// <summary>
        /// /// <summary>
        /// 自定义数据类型，对应nvarchar(1000)
        /// </summary>
        UDT_Nvarchar_1000 = 10,

        /// <summary>
        /// /// <summary>
        /// 自定义数据类型，对应nvarchar(max)
        /// </summary>
        UDT_Nvarchar_max = 11,

        /// <summary>
        /// /// <summary>
        /// 自定义数据类型，对应varbinary(max)
        /// </summary>
        UDT_Varbinary_max = 12,

        /// <summary>
        /// 自定义数据类型，对应nvarchar(500)
        /// </summary>
        UDT_Nvarchar_400 = 13,

        /// <summary>
        /// 错误类型
        /// </summary>
        Error = 0
    }
}
