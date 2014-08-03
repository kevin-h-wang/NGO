using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Founder.FIS.CMD.Tool.UI.UserControls
{
    public partial class ImportSheetUserControl : UserControl
    {
        public ImportSheetUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dgvConfig.Rows.Add();
        }

        private void dgvConfig_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvConfig.Rows[e.RowIndex].Cells["Required"].Value = "N";
            dgvConfig.Rows[e.RowIndex].Cells["DataType"].Value = "STRING";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvConfig.CurrentRow;
            dgvConfig.Rows.Remove(row);
        }
    }
}
