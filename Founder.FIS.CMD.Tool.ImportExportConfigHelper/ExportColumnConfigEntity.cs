using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.ExportConfigHelper
{
    public class ExportColumnConfigEntity
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
        /// 数据类型
        /// </summary>
        public string DataType
        {
            get;
            set;
        }
        /// <summary>
        /// 列宽
        /// </summary>
        public int ColumnWidth
        {
            get;
            set;
        }
        /// <summary>
        /// 格式如：yyyy-MM-dd
        /// </summary>
        public string DateFormat
        {
            get;
            set;
        }
        /// <summary>
        /// 精度
        /// </summary>
        public int Precision
        {
            get;
            set;
        }
    }
}
