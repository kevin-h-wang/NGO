using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.ImportConfigHelper
{
    public class ImportExcelConfigEntity
    {
        /// <summary>
        /// Excel名字
        /// </summary>
        public string ExcelName
        {
            get;
            set;
        }

        private List<ImportSheetConfigEntity> sheets;
        /// <summary>
        /// 要导出的Excel的Sheet名字
        /// </summary>
        public List<ImportSheetConfigEntity> Sheets
        {
            get
            {
                if (sheets == null)
                {
                    sheets = new List<ImportSheetConfigEntity>();
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
