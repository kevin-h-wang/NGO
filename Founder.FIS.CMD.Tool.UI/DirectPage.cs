using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Founder.FIS.CMD.Tool.UI
{
    public partial class DirectPage : Form
    {
        public DirectPage()
        {
            InitializeComponent();
        }

        private void btnPageTool_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog(this);
            if (login.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigHelperForm configForm = new ConfigHelperForm();
            configForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TableImport configForm = new TableImport();
            configForm.Show();
        }
    }
}
