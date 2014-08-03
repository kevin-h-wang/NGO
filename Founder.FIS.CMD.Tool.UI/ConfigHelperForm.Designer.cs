namespace Founder.FIS.CMD.Tool.UI
{
    partial class ConfigHelperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigHelperForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tcSheets = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtImportExcelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbExport = new System.Windows.Forms.TabControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddExport = new System.Windows.Forms.Button();
            this.btnGenerateExport = new System.Windows.Forms.Button();
            this.txtExportName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "导入配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tcSheets);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 375);
            this.panel2.TabIndex = 6;
            // 
            // tcSheets
            // 
            this.tcSheets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSheets.Location = new System.Drawing.Point(0, 0);
            this.tcSheets.Name = "tcSheets";
            this.tcSheets.SelectedIndex = 0;
            this.tcSheets.Size = new System.Drawing.Size(740, 375);
            this.tcSheets.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtImportExcelName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 43);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "增加Sheet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "生成配置文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImportExcelName
            // 
            this.txtImportExcelName.Location = new System.Drawing.Point(204, 12);
            this.txtImportExcelName.Name = "txtImportExcelName";
            this.txtImportExcelName.Size = new System.Drawing.Size(148, 21);
            this.txtImportExcelName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ExcelName";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbExport);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "导出配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbExport
            // 
            this.tbExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbExport.Location = new System.Drawing.Point(3, 46);
            this.tbExport.Name = "tbExport";
            this.tbExport.SelectedIndex = 0;
            this.tbExport.Size = new System.Drawing.Size(740, 375);
            this.tbExport.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddExport);
            this.panel3.Controls.Add(this.btnGenerateExport);
            this.panel3.Controls.Add(this.txtExportName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 43);
            this.panel3.TabIndex = 6;
            // 
            // btnAddExport
            // 
            this.btnAddExport.Location = new System.Drawing.Point(428, 10);
            this.btnAddExport.Name = "btnAddExport";
            this.btnAddExport.Size = new System.Drawing.Size(75, 23);
            this.btnAddExport.TabIndex = 7;
            this.btnAddExport.Text = "增加Sheet";
            this.btnAddExport.UseVisualStyleBackColor = true;
            this.btnAddExport.Click += new System.EventHandler(this.btnAddExport_Click);
            // 
            // btnGenerateExport
            // 
            this.btnGenerateExport.Location = new System.Drawing.Point(546, 10);
            this.btnGenerateExport.Name = "btnGenerateExport";
            this.btnGenerateExport.Size = new System.Drawing.Size(87, 23);
            this.btnGenerateExport.TabIndex = 6;
            this.btnGenerateExport.Text = "生成配置文件";
            this.btnGenerateExport.UseVisualStyleBackColor = true;
            this.btnGenerateExport.Click += new System.EventHandler(this.btnGenerateExport_Click);
            // 
            // txtExportName
            // 
            this.txtExportName.Location = new System.Drawing.Point(204, 12);
            this.txtExportName.Name = "txtExportName";
            this.txtExportName.Size = new System.Drawing.Size(148, 21);
            this.txtExportName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ExcelName";
            // 
            // ConfigHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigHelperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入导出配置";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tcSheets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtImportExcelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbExport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddExport;
        private System.Windows.Forms.Button btnGenerateExport;
        private System.Windows.Forms.TextBox txtExportName;
        private System.Windows.Forms.Label label2;
    }
}