using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.ImportConfigHelper
{
    public class ImportColumnConfigEntity
    {
        /// <summary>
        /// 列标题
        /// </summary>
        public string Title
        {
            get;
            set;
        }


        /// <summary>
        /// 对应的数据库字段名
        /// </summary>
        public string ColumnName
        {
            get;
            set;
        }


        /// <summary>
        /// 是否必填，只能输入Y/N
        /// </summary>
        public string Required
        {
            get;
            set;
        }


        /// <summary>
        /// 最大值(数字、日期)
        /// </summary>
        public string MaxValue
        {
            get;
            set;
        }

        /// <summary>
        /// 最小值(数字、日期)
        /// </summary>
        public string MinValue
        {
            get;
            set;
        }


        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType
        {
            get;
            set;
        }


        /// <summary>
        /// 字段长度
        /// </summary>
        public string Length
        {
            get;
            set;
        }

        private List<string> dataOptions;
        /// <summary>
        /// 可选项，用英文逗号分隔，如：男,女
        /// </summary>
        public List<string> DataOptions
        {
            get
            {
                if (dataOptions == null)
                {
                    dataOptions = new List<string>();
                }
                return dataOptions;
            }
            set { dataOptions = value; }
        }


        /// <summary>
        /// 正则表达式
        /// </summary>
        public string RegularExpression
        {
            get;
            set;
        }

    }
}

