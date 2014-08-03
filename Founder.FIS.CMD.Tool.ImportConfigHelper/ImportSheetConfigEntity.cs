using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.ImportConfigHelper
{
    public class ImportSheetConfigEntity
    {
        private List<ImportColumnConfigEntity> columns;
        /// <summary>
        /// Excel中每个Sheet的列
        /// </summary>
        public List<ImportColumnConfigEntity> Columns
        {
            get
            {
                if (columns == null)
                {
                    columns = new List<ImportColumnConfigEntity>();
                }
                return columns;
            }
            set { columns = value; }
        }
        /// <summary>
        /// 数据开始行
        /// </summary>
        public int StartRow
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
