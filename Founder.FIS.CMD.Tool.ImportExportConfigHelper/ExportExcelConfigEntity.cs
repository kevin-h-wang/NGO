using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.ExportConfigHelper
{
    public class ExportExcelConfigEntity
    {
        /// <summary>
        /// Excel名字
        /// </summary>
        public string ExcelName
        {
            get;
            set;
        }
        private List<ExportSheetConfigEntity> sheets;
        /// <summary>
        /// 要导出的Excel的Sheet名字
        /// </summary>
        public List<ExportSheetConfigEntity> Sheets
        {
            get
            {
                if (sheets == null)
                {
                    sheets = new List<ExportSheetConfigEntity>();
                }
                return sheets;
            }
            set
            {
                sheets = value;
            }
        }
    }
}
