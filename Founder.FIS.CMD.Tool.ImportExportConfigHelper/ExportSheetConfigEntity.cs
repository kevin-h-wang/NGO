using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.ExportConfigHelper
{
    public class ExportSheetConfigEntity
    {
        private List<ExportColumnConfigEntity> columns;
        /// <summary>
        /// Excel中每个Sheet的列
        /// </summary>
        public List<ExportColumnConfigEntity> Columns
        {
            get
            {
                if (columns == null)
                {
                    columns = new List<ExportColumnConfigEntity>();
                }
                return columns;
            }
            set
            {
                columns = value;
            }
        }
        /// <summary>
        /// 数据开始行
        /// </summary>
        public string SelectSQL
        {
            get;
            set;
        }
        /// <summary>
        /// 导入Excel的Sheet名字
        /// </summary>
        public string SheetName
        {
            get;
            set;
        }
    }
}
