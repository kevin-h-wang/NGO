using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Founder.FIS.CMD.Tool.Common;

namespace Founder.FIS.CMD.Tool.UI.Common
{
    /// <summary>
    /// 保存控件属性类
    /// </summary>
    public class PageControl
    {
        /// <summary>
        /// 控件名字
        /// </summary>
        public virtual string ControlName { get; set; }
        /// <summary>
        /// 控件描述
        /// </summary>
        public virtual string ControlDesc { get; set; }
        /// <summary>
        /// 控件类型
        /// </summary>
        public virtual EnumControlType ControlType { get; set; }
        /// <summary>
        /// 验证类型
        /// </summary>
        public virtual EnumValidateType ControlValidate { get; set; }

        /// <summary>
        /// 是否排序
        /// </summary>
        public virtual bool Sort { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public virtual string ColumnType { get; set; }

        /// <summary>
        /// 控件ID
        /// </summary>
        public virtual string ControlID
        {
            get
            {
                string id = string.Empty;
                switch (ControlType)
                {
                    case EnumControlType.FIButton:
                        id = "btn" + ControlName;
                        break;
                    case EnumControlType.FIDatePicker:
                        id = "dp" + ControlName;
                        break;
                    case EnumControlType.FICheckBox:
                        id = "cb" + ControlName;
                        break;
                    case EnumControlType.FICheckBoxList:
                        id = "cbl" + ControlName;
                        break;
                    case EnumControlType.FIDropDownList:
                        id = "ddl" + ControlName;
                        break;
                    case EnumControlType.FIDropDownCheckListEx:
                    case EnumControlType.FIEditableDropDownList:
                    case EnumControlType.FIEditableDropDownListEx:
                        id = "eddl" + ControlName;
                        break;
                    case EnumControlType.FIHiddenField:
                        id = "hf" + ControlName;
                        break;
                    case EnumControlType.FIHyperLink:
                        id = "hl" + ControlName;
                        break;
                    case EnumControlType.FIImageButton:
                        id = "ibtn" + ControlName;
                        break;
                    case EnumControlType.FILabel:
                        id = "lbl" + ControlName;
                        break;
                    case EnumControlType.FILiteral:
                        id = "lit" + ControlName;
                        break;
                    case EnumControlType.FILinkButton:
                        id = "lbtn" + ControlName;
                        break;
                    case EnumControlType.FIFileUpload:
                        id = "fu" + ControlName;
                        break;
                    case EnumControlType.FIRepeater:
                        id = "rpt" + ControlName;
                        break;
                    case EnumControlType.FIRadioButton:
                        id = "rbtn" + ControlName;
                        break;
                    case EnumControlType.FIRadioButtonList:
                        id = "rbtnl" + ControlName;
                        break;
                    case EnumControlType.FITextBox:
                         id = "txt" + ControlName;
                        break;
                    case EnumControlType.FINumberTextBox:
                        id = "ntxt" + ControlName;
                        break;
                    case EnumControlType.FIEmailTextBox:
                        id = "etxt" + ControlName;
                        break;
                    case EnumControlType.FIAutoCompleteTextBox:
                    case EnumControlType.FIAutoCompleteTextBoxEx:
                        id = "atxt" + ControlName;
                        break;
                    case EnumControlType.FIAutoTextArea:
                        id = "atxts" + ControlName;
                        break;
                }
                return id;
            }
        }
        /// <summary>
        /// 是否默认排序字段
        /// </summary>
        public virtual bool DefaultSortExpression { get; set; }

        //public virtual List<ValidateControl> ValidateControlList
        //{
        //    get
        //    {
        //        List<ValidateControl> validateControlList = new List<ValidateControl>();
        //        ValidateControl validateControl = null;
        //        switch (ControlValidate)
        //        {

        //            case EnumValidateType.必填字符串:
        //                validateControl = new ValidateControl();
        //                validateControl.ControlName = "RequiredFieldValidator";
        //                validateControl.ControlID = "RequiredFieldValidator" + ControlID;
        //                validateControlList.Add(validateControl);
        //                break;
        //            case EnumValidateType.必填整数:
        //            case EnumValidateType.必填实数:
        //            case EnumValidateType.必填日期:
        //                validateControl = new ValidateControl();
        //                validateControl.ControlName = "RequiredFieldValidator";
        //                validateControl.ControlID = "RequiredFieldValidator" + ControlID;
        //                validateControlList.Add(validateControl);
        //                validateControl = new ValidateControl();
        //                validateControl.ControlName = "RangeValidator";
        //                validateControl.ControlID = "RangeValidator" + ControlID;
        //                validateControlList.Add(validateControl);
        //                break;
        //            case EnumValidateType.必填邮箱:
        //                validateControl = new ValidateControl();
        //                validateControl.ControlName = "RequiredFieldValidator";
        //                validateControl.ControlID = "RequiredFieldValidator" + ControlID;
        //                validateControlList.Add(validateControl);
        //                validateControl = new ValidateControl();
        //                validateControl.ControlName = "RegularExpressionValidator";
        //                validateControl.ControlID = "RegularExpressionValidator" + ControlID;
        //                validateControlList.Add(validateControl);
        //                break;
        //        }
        //        return validateControlList;
        //    }
        //}

    }

    public class ValidateControl
    {
        public virtual string ControlName { get; set; }
        public virtual string ControlID { get; set; }
    }
}
