namespace Founder.FIS.CMD.Tool.UI.UserControls
{
    partial class ImportSheetUserControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConfig = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Required = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegularExpression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.txtStartRow = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SheetName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "StartRow";
            // 
            // dgvConfig
            // 
            this.dgvConfig.AllowUserToAddRows = false;
            this.dgvConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.ColumnName,
            this.Required,
            this.DataType,
            this.MaxValue,
            this.MinValue,
            this.Length,
            this.DataOptions,
            this.RegularExpression});
            this.dgvConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConfig.Location = new System.Drawing.Point(0, 0);
            this.dgvConfig.Name = "dgvConfig";
            this.dgvConfig.RowTemplate.Height = 23;
            this.dgvConfig.Size = new System.Drawing.Size(1047, 270);
            this.dgvConfig.TabIndex = 2;
            this.dgvConfig.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvConfig_RowsAdded);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 120;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "ColumnName";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 120;
            // 
            // Required
            // 
            dataGridViewCellStyle1.NullValue = "N";
            this.Required.DefaultCellStyle = dataGridViewCellStyle1;
            this.Required.HeaderText = "Required";
            this.Required.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.Required.Name = "Required";
            this.Required.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Required.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DataType
            // 
            dataGridViewCellStyle2.NullValue = "String";
            this.DataType.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataType.HeaderText = "DataType";
            this.DataType.Items.AddRange(new object[] {
            "INT",
            "DECIMAL",
            "DATATIME",
            "STRING"});
            this.DataType.Name = "DataType";
            this.DataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaxValue
            // 
            this.MaxValue.HeaderText = "MaxValue";
            this.MaxValue.Name = "MaxValue";
            // 
            // MinValue
            // 
            this.MinValue.HeaderText = "MinValue";
            this.MinValue.Name = "MinValue";
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            // 
            // DataOptions
            // 
            this.DataOptions.HeaderText = "DataOptions";
            this.DataOptions.Name = "DataOptions";
            // 
            // RegularExpression
            // 
            this.RegularExpression.HeaderText = "RegularExpression";
            this.RegularExpression.Name = "RegularExpression";
            this.RegularExpression.Width = 120;
            // 
            // txtSheetName
            // 
            this.txtSheetName.Location = new System.Drawing.Point(120, 23);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(259, 21);
            this.txtSheetName.TabIndex = 3;
            // 
            // txtStartRow
            // 
            this.txtStartRow.Location = new System.Drawing.Point(514, 23);
            this.txtStartRow.Name = "txtStartRow";
            this.txtStartRow.Size = new System.Drawing.Size(186, 21);
            this.txtStartRow.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStartRow);
            this.panel1.Controls.Add(this.txtSheetName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 67);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "增加一行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvConfig);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 270);
            this.panel2.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(893, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除一行";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ImportSheetUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ImportSheetUserControl";
            this.Size = new System.Drawing.Size(1047, 337);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConfig;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.TextBox txtStartRow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Required;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegularExpression;
        private System.Windows.Forms.Button btnDelete;
    }
}
