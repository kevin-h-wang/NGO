using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Founder.FIS.CMD.Tool.BusinessLogic;
using Founder.FIS.CMD.Tool.Common;
using Founder.FIS.CMD.Tool.UI.Common;

namespace Founder.FIS.CMD.Tool.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            gridViewMain.AutoGenerateColumns = false;
        }

        public MainFormBLL MainFormBLL
        {
            get
            {
                return new MainFormBLL();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTableNameList();
            InitDropDownList();
            InitSavePath();
        }

        #region 设置保存路径
        private void InitSavePath()
        {
            this.txtSavePath.Text = ConfigurationManager.AppSettings["DefaultSavePath"];
            this.folderBrowserDialog.SelectedPath = ConfigurationManager.AppSettings["DefaultSavePath"];
        }
        #endregion

        #region 初始化TableName
        private void InitTableNameList()
        {
            listBoxTableName.DataSource = MainFormBLL.GetAllTableName();
            listBoxTableName.DisplayMember = "TableName";
            listBoxTableName.ValueMember = "TableName";
            GetTableInfo();
        }
        #endregion

        #region 初始化下拉
        private void InitDropDownList()
        {
            this.ColumnControlType.DataSource = FormHelper.GetListViaEnum(typeof(EnumControlType), false);
            this.ColumnControlType.ValueMember = "Value";
            this.ColumnControlType.DisplayMember = "Name";
            this.ColumnControlType.DefaultCellStyle.NullValue = EnumControlType.FITextBox.ToString();
            this.ColumnControlType.DefaultCellStyle.DataSourceNullValue = EnumControlType.FITextBox.ToString();

            this.ColumnIsValidate.DataSource = FormHelper.GetListViaEnum(typeof(EnumValidateType), false);
            this.ColumnIsValidate.ValueMember = "Value";
            this.ColumnIsValidate.DisplayMember = "Name";
            this.ColumnIsValidate.DefaultCellStyle.NullValue = EnumValidateType.无.ToString();
        }
        #endregion

        /// <summary>
        /// 选择实体保存路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectEntityPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                this.txtSavePath.Text = folderBrowserDialog.SelectedPath;
                FormHelper.SaveConfigKey("DefaultSavePath", folderBrowserDialog.SelectedPath);
            }
        }

        private void listBoxTableName_MouseClick(object sender, MouseEventArgs e)
        {
            GetTableInfo();
        }

        /// <summary>
        /// 生成事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (gridViewMain.DataSource == null)
            {
                MessageBox.Show("请选择数据库表进行生成！", "提示");
                return;
            }
            //检查数据表的字段类型是否符合要求
            if (!CheckColumnTypeValidate())
            {
                return;
            }
            string savePath = this.txtSavePath.Text.Trim();
            string defaultSavePath = ConfigurationManager.AppSettings["DefaultSavePath"];
            if (string.IsNullOrEmpty(savePath))
            {
                if (MessageBox.Show("是否保存到默认路径" + defaultSavePath + "？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    savePath = defaultSavePath;
                }
            }
            if (!string.IsNullOrEmpty(savePath))
            {
                if (!Directory.Exists(savePath))
                {
                    if (MessageBox.Show("找不到指定路径" + savePath + "，是否创建？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Directory.CreateDirectory(savePath);
                    }
                    else
                    {
                        return;
                    }
                }
                if (chkEntity.Checked || chkEditPage.Checked || chkListPage.Checked)
                {
                    GenerateInfo generateInfo = new GenerateInfo();
                    generateInfo.TableName = this.listBoxTableName.SelectedValue.ToString();
                    generateInfo.TableDesc = this.lblTableDesc.Text.Trim();
                    generateInfo.SavePath = savePath;
                    generateInfo.Module = this.txtModule.Text.Trim();
                    generateInfo.EditColumnNumber = Convert.ToInt16(this.txtEditLayout.Text.Trim());
                    generateInfo.ListColumnNumber = Convert.ToInt16(this.txtListLayout.Text.Trim());
                    generateInfo.IsCanExport = this.chkExport.Checked;
                    generateInfo.NameSpace = this.txtNameSpace.Text.Trim();
                    generateInfo.Assembly = this.txtAssembly.Text.Trim() == "" ? this.txtNameSpace.Text.Trim() : this.txtAssembly.Text.Trim();
                    generateInfo.EntityName = generateInfo.TableName.Substring(generateInfo.TableName.LastIndexOf("_", StringComparison.Ordinal) + 1) + "Entity";
                    GenerateFile(generateInfo);
                    MessageBox.Show("生成成功！", "消息");
                }
                else
                {
                    MessageBox.Show("请选择生成选项！", "提示");
                }
            }
        }

        /// <summary>
        /// 生成文件
        /// </summary>
        /// <param name="generateInfo"></param>
        private void GenerateFile(GenerateInfo generateInfo)
        {
            //实体
            if (chkEntity.Checked)
            {
                GenerateFileHelper.GenerateEntityFile(generateInfo, gridViewMain);
                GenerateFileHelper.GenerateEntityMapFile(generateInfo, gridViewMain);
            }
            //编辑页面
            if (chkEditPage.Checked)
            {
                GenerateFileHelper.GenerateEditWebFormFile(generateInfo, gridViewMain);
            }
            //列表页面
            if (chkListPage.Checked)
            {
                if (radioButtonBasic.Checked)
                {
                    GenerateFileHelper.GenerateListWebFormFile(generateInfo, gridViewMain);
                }
                else
                {
                    GenerateFileHelper.GenerateCommonQueryListWebFormFile(generateInfo, gridViewMain);
                }
            }
            //数据存储
            if (chkLogic.Checked)
            {
                GenerateFileHelper.GenerateLogicFile(generateInfo, gridViewMain);
            }
        }

        private void btnListQuerySQL_Click(object sender, EventArgs e)
        {
            if (chkListPage.Checked)
            {
                if (gridViewMain.DataSource == null)
                {
                    MessageBox.Show("请选择数据库表进行操作！", "提示");
                    return;
                }
                GenerateFileHelper.CopyQuerySqlToClipBoard(this.listBoxTableName.SelectedValue.ToString(), gridViewMain);
                MessageBox.Show("查询SQL已拷贝到剪贴板，可以使用 Ctrl + V 快捷键进行复制使用！");
            }
        }

        private bool CheckColumnTypeValidate()
        {
            foreach (DataGridViewRow row in gridViewMain.Rows)
            {
                CMD2DBType cmd2DBType = FormHelper.ConvertStrToCMD2DBType(row.Cells["ColumnType"].Value.ToString());
                if (cmd2DBType == CMD2DBType.Error)
                {
                    MessageBox.Show(string.Format("数据表字段【{0}】的类型【{1}】不符合规范，请修改后重新生成！",
                        row.Cells["ColumnName"].Value.ToString(),
                        row.Cells["ColumnType"].Value.ToString()), "警告");
                    return false;
                }
            }
            return true;
        }

        private void ToolStripMenuItemRefersh_Click(object sender, EventArgs e)
        {
            InitTableNameList();
        }

        private void GridViewToolStripMenuItemRefersh_Click(object sender, EventArgs e)
        {
            GetTableInfo();
        }

        /// <summary>
        /// 获取数据表的信息
        /// </summary>
        private void GetTableInfo()
        {
            if (listBoxTableName.SelectedValue != null)
            {
                DataTable dt = MainFormBLL.GetTableInfo(listBoxTableName.SelectedValue.ToString());
                if (dt != null && dt.Rows.Count > 0)
                {
                    gridViewMain.DataSource = dt;
                    this.Text = "页面生成工具——表名：" + dt.Rows[0]["TableName"].ToString();
                    lblTableDesc.Text = dt.Rows[0]["TableDesc"].ToString();
                }
                else
                {
                    gridViewMain.DataSource = null;
                    this.Text = "页面生成工具";
                    lblTableDesc.Text = "";
                }

                foreach (DataGridViewRow row in gridViewMain.Rows)
                {
                    if (string.IsNullOrWhiteSpace(row.Cells["ColumnIsNullable"].Value.ToString()))
                    {
                        row.Cells["ColumnIsValidate"].Style.NullValue = EnumValidateType.必填.ToString();
                    }
                }
            }
        }

        #region 列表页面改变事件
        private void chkListPage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkListPage.Checked)
            {
                this.radionButtonPanel.Visible = true;
            }
            else
            {
                this.radionButtonPanel.Visible = false;
            }
        }
        #endregion

        #region 键盘按下松开事件
        private void txtFiliter_KeyUp(object sender, KeyEventArgs e)
        {
            //上下左右
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                if (listBoxTableName.SelectedIndex > 0)
                {
                    listBoxTableName.SelectedIndex--;
                    GetTableInfo();
                }
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                if (listBoxTableName.SelectedIndex < listBoxTableName.Items.Count - 1)
                {
                    listBoxTableName.SelectedIndex++;
                    GetTableInfo();
                }
            }
            //回车
            else if (e.KeyCode == Keys.Enter)
            {
                this.txtFiliter.Text = this.listBoxTableName.SelectedValue.ToString();
            }
            else
            {

                if (txtFiliter.Text != "")
                {
                    DataTable dataSource = MainFormBLL.GetAllTableNameFilter(txtFiliter.Text.Trim());
                    listBoxTableName.DataSource = dataSource;
                    listBoxTableName.DisplayMember = "TableName";
                    listBoxTableName.ValueMember = "TableName";
                    GetTableInfo();
                }
            }
            txtFiliter.Select(txtFiliter.Text.Length, 1); //光标定位到文本框最后
        }
        #endregion

        private void listBoxTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTableInfo();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ConfigHelperForm configForm = new ConfigHelperForm();
            configForm.Show();
        }

        private void btnGenerateTable_Click(object sender, EventArgs e)
        {
            TableImport configForm = new TableImport();
            configForm.Show();
        }
    }
}
