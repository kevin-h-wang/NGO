using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Founder.FIS.CMD.Tool.ImportConfigHelper;
using Founder.FIS.CMD.Tool.UI.UserControls;
using Founder.FIS.CMD.Tool.UI.Common;
using System.Configuration;
using System.IO;
using System.Xml;
using Founder.FIS.CMD.Tool.ExportConfigHelper;

namespace Founder.FIS.CMD.Tool.UI
{
    public partial class ConfigHelperForm : Form
    {
        public ConfigHelperForm()
        {
            InitializeComponent();

        }

        #region 导出
        private void button2_Click_1(object sender, EventArgs e)
        {
            TabPage page = new TabPage();
            page.Text = "Page" + (tcSheets.TabPages.Count + 1).ToString();
            ImportSheetUserControl uc = new ImportSheetUserControl();
            uc.Dock = DockStyle.Fill;
            page.Controls.Add(uc);
            tcSheets.TabPages.Add(page);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                ImportExcelConfigEntity excel = new ImportExcelConfigEntity();
                excel.ExcelName = txtImportExcelName.Text.Trim();
                foreach (TabPage page in tcSheets.TabPages)
                {
                    TextBox txtSheetName = page.Controls.Find("txtSheetName", true)[0] as TextBox;
                    TextBox txtStartRow = page.Controls.Find("txtStartRow", true)[0] as TextBox;
                    ImportSheetConfigEntity sheet = new ImportSheetConfigEntity();
                    sheet.SheetName = txtSheetName.Text.Trim();
                    sheet.StartRow = txtStartRow.Text.Trim().ToInt().Value;

                    DataGridView grid = page.Controls.Find("dgvConfig", true)[0] as DataGridView;
                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        ImportColumnConfigEntity col = new ImportColumnConfigEntity();
                        col.Title = row.Cells["Title"].Value.ToStringEx();
                        col.ColumnName = row.Cells["ColumnName"].Value.ToStringEx();
                        col.Required = row.Cells["Required"].Value.ToStringEx();
                        col.DataType = row.Cells["DataType"].Value.ToStringEx();
                        col.MaxValue = row.Cells["MaxValue"].Value.ToStringEx();
                        col.MinValue = row.Cells["MinValue"].Value.ToStringEx();
                        col.Length = row.Cells["Length"].Value.ToStringEx();
                        if (!row.Cells["DataOptions"].Value.ToStringEx().Trim().IsNullOrEmpty())
                        {
                            col.DataOptions = row.Cells["DataOptions"].Value.ToStringEx().Trim().Split(',').ToList();
                        }
                        col.RegularExpression = row.Cells["RegularExpression"].Value.ToStringEx();

                        sheet.Columns.Add(col);
                    }
                    excel.Sheets.Add(sheet);
                }

                List<ImportExcelConfigEntity> lst = new List<ImportExcelConfigEntity>();
                lst.Add(excel);
                string xml = FISerializeHelper.SerializeObjectToXmlString<List<ImportExcelConfigEntity>>(lst);
                string savePath = ConfigurationManager.AppSettings["XMLSavePath"] + @"Import\";
                if (!string.IsNullOrEmpty(savePath))
                {
                    if (!Directory.Exists(savePath))
                    {
                        Directory.CreateDirectory(savePath);
                    }
                    GenerateFileHelper.GenerateFile(xml, savePath + excel.ExcelName + @".xml");
                    MessageBox.Show("生成成功！", "消息");
                    System.Diagnostics.Process.Start("Explorer.exe", savePath);
                }
            }
        }

        private bool CheckInput()
        {
            bool returnValue = true;
            if (string.IsNullOrEmpty(txtImportExcelName.Text.Trim()))
            {
                MessageBox.Show("ExcelName不能为空！");
                returnValue = false;
            }
            int index = 1;
            foreach (TabPage page in tcSheets.TabPages)
            {
                TextBox txtSheetName = page.Controls.Find("txtSheetName", true)[0] as TextBox;
                if (txtSheetName.Text.Trim().IsNullOrEmpty())
                {
                    MessageBox.Show(string.Format("第{0}个Sheet的名字不能为空！", index));
                    returnValue = false;
                }
                TextBox txtStartRow = page.Controls.Find("txtStartRow", true)[0] as TextBox;
                if (!txtStartRow.Text.IsInteger())
                {
                    MessageBox.Show(string.Format("第{0}个Sheet的开始行必须是整数！", index));
                    returnValue = false;
                }

                DataGridView grid = page.Controls.Find("dgvConfig", true)[0] as DataGridView;
                if (grid.Rows.Count <= 0)
                {
                    MessageBox.Show(string.Format("第{0}个Sheet的列为空！", index));
                    returnValue = false;
                }
                int indexColumn = 1;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    string title = row.Cells["Title"].Value.ToStringEx();
                    if (title.IsNullOrEmpty())
                    {
                        MessageBox.Show(string.Format("第{0}个Sheet第{1}行的Title不能为空！", index, indexColumn));
                        returnValue = false;
                    }
                    string columnName = row.Cells["ColumnName"].Value.ToStringEx();
                    if (columnName.IsNullOrEmpty())
                    {
                        MessageBox.Show(string.Format("第{0}个Sheet第{1}行的ColumnName不能为空！", index, indexColumn));
                        returnValue = false;
                    }

                    string length = row.Cells["Length"].Value.ToStringEx();
                    if (!length.IsNumber())
                    {
                        MessageBox.Show(string.Format("第{0}个Sheet第{1}行的Length必须为数字！", index, indexColumn));
                        returnValue = false;
                    }
                    indexColumn++;
                }
                index++;
            }

            return returnValue;
        }
        #endregion 

        #region 导入
        private void btnAddExport_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage();
            page.Text = "Page" + (tcSheets.TabPages.Count + 1).ToString();
            ExportSheetUserControl uc = new ExportSheetUserControl();
            uc.Dock = DockStyle.Fill;
            page.Controls.Add(uc);
            tbExport.TabPages.Add(page);
        }

        private bool CheckExportInput()
        {
            bool returnValue = true;
            if (string.IsNullOrEmpty(txtExportName.Text.Trim()))
            {
                MessageBox.Show("ExcelName不能为空！");
                returnValue = false;
            }
            int index = 1;
            foreach (TabPage page in tbExport.TabPages)
            {
                TextBox txtSheetName = page.Controls.Find("txtSheetName", true)[0] as TextBox;
                if (txtSheetName.Text.Trim().IsNullOrEmpty())
                {
                    MessageBox.Show(string.Format("第{0}个Sheet的名字不能为空！", index));
                    returnValue = false;
                }
                TextBox txtStartRow = page.Controls.Find("txtSelectSQL", true)[0] as TextBox;
                if (txtStartRow.Text.Trim().IsNullOrEmpty())
                {
                    MessageBox.Show(string.Format("第{0}个Sheet的SQL不能为空！", index));
                    returnValue = false;
                }

                DataGridView grid = page.Controls.Find("dgvConfig", true)[0] as DataGridView;
                if (grid.Rows.Count <= 0)
                {
                    MessageBox.Show(string.Format("第{0}个Sheet的列为空！", index));
                    returnValue = false;
                }
                int indexColumn = 1;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    string title = row.Cells["Title"].Value.ToStringEx();
                    if (title.IsNullOrEmpty())
                    {
                        MessageBox.Show(string.Format("第{0}个Sheet第{1}行的Title不能为空！", index, indexColumn));
                        returnValue = false;
                    }
                    string columnName = row.Cells["ColumnName"].Value.ToStringEx();
                    if (columnName.IsNullOrEmpty())
                    {
                        MessageBox.Show(string.Format("第{0}个Sheet第{1}行的ColumnName不能为空！", index, indexColumn));
                        returnValue = false;
                    }
                    string width = row.Cells["ColumnWidth"].Value.ToStringEx();
                    if (!width.IsNumber())
                    {
                        MessageBox.Show(string.Format("第{0}个Sheet第{1}行的ColumnWidth必须为数字！", index, indexColumn));
                        returnValue = false;
                    }
                    string precision = row.Cells["Precision"].Value.ToStringEx();
                    if (!precision.IsNumber())
                    {
                        MessageBox.Show(string.Format("第{0}个Sheet第{1}行的Precision必须为数字！", index, indexColumn));
                        returnValue = false;
                    }
                    indexColumn++;
                }
                index++;
            }

            return returnValue;
        }
        #endregion

        private void btnGenerateExport_Click(object sender, EventArgs e)
        {
            if (CheckExportInput())
            {
                ExportExcelConfigEntity excel = new ExportExcelConfigEntity();
                excel.ExcelName = txtExportName.Text.Trim();
                foreach (TabPage page in tbExport.TabPages)
                {
                    TextBox txtSheetName = page.Controls.Find("txtSheetName", true)[0] as TextBox;
                    TextBox txtStartRow = page.Controls.Find("txtSelectSQL", true)[0] as TextBox;
                    ExportSheetConfigEntity sheet = new ExportSheetConfigEntity();
                    sheet.SheetName = txtSheetName.Text.Trim();
                    sheet.SelectSQL = txtStartRow.Text.Trim();

                    DataGridView grid = page.Controls.Find("dgvConfig", true)[0] as DataGridView;
                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        ExportColumnConfigEntity col = new ExportColumnConfigEntity();
                        col.Title = row.Cells["Title"].Value.ToStringEx();
                        col.ColumnName = row.Cells["ColumnName"].Value.ToStringEx();
                        col.DataType = row.Cells["DataType"].Value.ToStringEx();
                        col.ColumnWidth = row.Cells["ColumnWidth"].Value.ToInt32();
                        col.Precision = row.Cells["Precision"].Value.ToInt32();
                        col.DateFormat = row.Cells["DateFormat"].Value.ToStringEx();

                        sheet.Columns.Add(col);
                    }
                    excel.Sheets.Add(sheet);
                }

                List<ExportExcelConfigEntity> lst = new List<ExportExcelConfigEntity>();
                lst.Add(excel);
                string xml = FISerializeHelper.SerializeObjectToXmlString<List<ExportExcelConfigEntity>>(lst);
                string savePath = ConfigurationManager.AppSettings["XMLSavePath"] + @"Export\";
                if (!string.IsNullOrEmpty(savePath))
                {
                    if (!Directory.Exists(savePath))
                    {
                        Directory.CreateDirectory(savePath);
                    }
                    GenerateFileHelper.GenerateFile(xml, savePath + excel.ExcelName + @".xml");
                    MessageBox.Show("生成成功！", "消息");
                    System.Diagnostics.Process.Start("Explorer.exe", savePath);
                }
            }
        }
    }
}
