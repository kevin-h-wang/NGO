namespace Founder.FIS.CMD.Tool.UI
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnGenerateTable = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radionButtonPanel = new System.Windows.Forms.Panel();
            this.radioButtonBasic = new System.Windows.Forms.RadioButton();
            this.radioButtonCommon = new System.Windows.Forms.RadioButton();
            this.chkLogic = new System.Windows.Forms.CheckBox();
            this.chkExport = new System.Windows.Forms.CheckBox();
            this.btnListQuerySQL = new System.Windows.Forms.Button();
            this.chkListPage = new System.Windows.Forms.CheckBox();
            this.chkEditPage = new System.Windows.Forms.CheckBox();
            this.chkEntity = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAssembly = new System.Windows.Forms.Label();
            this.txtAssembly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblListCol = new System.Windows.Forms.Label();
            this.txtListLayout = new System.Windows.Forms.TextBox();
            this.lblListLayout = new System.Windows.Forms.Label();
            this.lblEditCol = new System.Windows.Forms.Label();
            this.txtEditLayout = new System.Windows.Forms.TextBox();
            this.lblEditLayout = new System.Windows.Forms.Label();
            this.btnSelectEntityPath = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.lblEntitySavePath = new System.Windows.Forms.Label();
            this.lblTableDesc = new System.Windows.Forms.Label();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelMiddleMiddle = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridViewMain = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnControlType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnIsPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsNullable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsValidate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnIsEditControl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnIsQueryFilter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnIsListControl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnIsOrderInListPage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDefaultSortExpression = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStripGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GridViewToolStripMenuItemRefersh = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listBoxTableName = new System.Windows.Forms.ListBox();
            this.contextMenuStripTableName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemRefersh = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFiliter = new System.Windows.Forms.Label();
            this.txtFiliter = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelBottom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.radionButtonPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.panelMiddleMiddle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.contextMenuStripGridView.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel6.SuspendLayout();
            this.contextMenuStripTableName.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.groupBox1);
            this.panelBottom.Controls.Add(this.groupBox3);
            this.panelBottom.Controls.Add(this.groupBox2);
            this.panelBottom.Controls.Add(this.lblTableDesc);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 487);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1274, 138);
            this.panelBottom.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfig);
            this.groupBox1.Controls.Add(this.btnGenerateTable);
            this.groupBox1.Location = new System.Drawing.Point(1106, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 112);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "其他选项";
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(7, 24);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(90, 23);
            this.btnConfig.TabIndex = 28;
            this.btnConfig.Text = "导入导出配置";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnGenerateTable
            // 
            this.btnGenerateTable.Location = new System.Drawing.Point(6, 63);
            this.btnGenerateTable.Name = "btnGenerateTable";
            this.btnGenerateTable.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateTable.TabIndex = 29;
            this.btnGenerateTable.Text = "建表脚本";
            this.btnGenerateTable.UseVisualStyleBackColor = true;
            this.btnGenerateTable.Click += new System.EventHandler(this.btnGenerateTable_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radionButtonPanel);
            this.groupBox3.Controls.Add(this.chkLogic);
            this.groupBox3.Controls.Add(this.chkExport);
            this.groupBox3.Controls.Add(this.btnListQuerySQL);
            this.groupBox3.Controls.Add(this.chkListPage);
            this.groupBox3.Controls.Add(this.chkEditPage);
            this.groupBox3.Controls.Add(this.chkEntity);
            this.groupBox3.Controls.Add(this.btnGenerate);
            this.groupBox3.Location = new System.Drawing.Point(615, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 112);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "生成选项";
            // 
            // radionButtonPanel
            // 
            this.radionButtonPanel.Controls.Add(this.radioButtonBasic);
            this.radionButtonPanel.Controls.Add(this.radioButtonCommon);
            this.radionButtonPanel.Location = new System.Drawing.Point(264, 16);
            this.radionButtonPanel.Name = "radionButtonPanel";
            this.radionButtonPanel.Size = new System.Drawing.Size(200, 21);
            this.radionButtonPanel.TabIndex = 27;
            // 
            // radioButtonBasic
            // 
            this.radioButtonBasic.AutoSize = true;
            this.radioButtonBasic.Checked = true;
            this.radioButtonBasic.Location = new System.Drawing.Point(14, 2);
            this.radioButtonBasic.Name = "radioButtonBasic";
            this.radioButtonBasic.Size = new System.Drawing.Size(71, 16);
            this.radioButtonBasic.TabIndex = 25;
            this.radioButtonBasic.TabStop = true;
            this.radioButtonBasic.Text = "一般查询";
            this.radioButtonBasic.UseVisualStyleBackColor = true;
            // 
            // radioButtonCommon
            // 
            this.radioButtonCommon.AutoSize = true;
            this.radioButtonCommon.Location = new System.Drawing.Point(101, 2);
            this.radioButtonCommon.Name = "radioButtonCommon";
            this.radioButtonCommon.Size = new System.Drawing.Size(71, 16);
            this.radioButtonCommon.TabIndex = 26;
            this.radioButtonCommon.Text = "通用查询";
            this.radioButtonCommon.UseVisualStyleBackColor = true;
            // 
            // chkLogic
            // 
            this.chkLogic.AutoSize = true;
            this.chkLogic.Checked = true;
            this.chkLogic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogic.Location = new System.Drawing.Point(6, 42);
            this.chkLogic.Name = "chkLogic";
            this.chkLogic.Size = new System.Drawing.Size(72, 16);
            this.chkLogic.TabIndex = 24;
            this.chkLogic.Text = "数据存储";
            this.chkLogic.UseVisualStyleBackColor = true;
            // 
            // chkExport
            // 
            this.chkExport.AutoSize = true;
            this.chkExport.Checked = true;
            this.chkExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExport.Location = new System.Drawing.Point(87, 42);
            this.chkExport.Name = "chkExport";
            this.chkExport.Size = new System.Drawing.Size(72, 16);
            this.chkExport.TabIndex = 23;
            this.chkExport.Text = "支持导出";
            this.chkExport.UseVisualStyleBackColor = true;
            // 
            // btnListQuerySQL
            // 
            this.btnListQuerySQL.Location = new System.Drawing.Point(174, 74);
            this.btnListQuerySQL.Name = "btnListQuerySQL";
            this.btnListQuerySQL.Size = new System.Drawing.Size(131, 23);
            this.btnListQuerySQL.TabIndex = 22;
            this.btnListQuerySQL.Text = "拷贝列表查询SQL";
            this.btnListQuerySQL.UseVisualStyleBackColor = true;
            this.btnListQuerySQL.Click += new System.EventHandler(this.btnListQuerySQL_Click);
            // 
            // chkListPage
            // 
            this.chkListPage.AutoSize = true;
            this.chkListPage.Checked = true;
            this.chkListPage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkListPage.Location = new System.Drawing.Point(188, 18);
            this.chkListPage.Name = "chkListPage";
            this.chkListPage.Size = new System.Drawing.Size(72, 16);
            this.chkListPage.TabIndex = 21;
            this.chkListPage.Text = "列表页面";
            this.chkListPage.UseVisualStyleBackColor = true;
            this.chkListPage.CheckedChanged += new System.EventHandler(this.chkListPage_CheckedChanged);
            // 
            // chkEditPage
            // 
            this.chkEditPage.AutoSize = true;
            this.chkEditPage.Checked = true;
            this.chkEditPage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEditPage.Location = new System.Drawing.Point(87, 18);
            this.chkEditPage.Name = "chkEditPage";
            this.chkEditPage.Size = new System.Drawing.Size(72, 16);
            this.chkEditPage.TabIndex = 20;
            this.chkEditPage.Text = "编辑页面";
            this.chkEditPage.UseVisualStyleBackColor = true;
            // 
            // chkEntity
            // 
            this.chkEntity.AutoSize = true;
            this.chkEntity.Checked = true;
            this.chkEntity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntity.Location = new System.Drawing.Point(6, 18);
            this.chkEntity.Name = "chkEntity";
            this.chkEntity.Size = new System.Drawing.Size(48, 16);
            this.chkEntity.TabIndex = 19;
            this.chkEntity.Text = "实体";
            this.chkEntity.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(35, 74);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAssembly);
            this.groupBox2.Controls.Add(this.txtAssembly);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNameSpace);
            this.groupBox2.Controls.Add(this.txtModule);
            this.groupBox2.Controls.Add(this.lblModule);
            this.groupBox2.Controls.Add(this.lblListCol);
            this.groupBox2.Controls.Add(this.txtListLayout);
            this.groupBox2.Controls.Add(this.lblListLayout);
            this.groupBox2.Controls.Add(this.lblEditCol);
            this.groupBox2.Controls.Add(this.txtEditLayout);
            this.groupBox2.Controls.Add(this.lblEditLayout);
            this.groupBox2.Controls.Add(this.btnSelectEntityPath);
            this.groupBox2.Controls.Add(this.txtSavePath);
            this.groupBox2.Controls.Add(this.lblEntitySavePath);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 123);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "页面设置";
            // 
            // lblAssembly
            // 
            this.lblAssembly.AutoSize = true;
            this.lblAssembly.Location = new System.Drawing.Point(9, 101);
            this.lblAssembly.Name = "lblAssembly";
            this.lblAssembly.Size = new System.Drawing.Size(53, 12);
            this.lblAssembly.TabIndex = 31;
            this.lblAssembly.Text = "程序集：";
            // 
            // txtAssembly
            // 
            this.txtAssembly.Location = new System.Drawing.Point(129, 98);
            this.txtAssembly.Name = "txtAssembly";
            this.txtAssembly.Size = new System.Drawing.Size(368, 21);
            this.txtAssembly.TabIndex = 30;
            this.txtAssembly.Text = "Founder.FIS.CMD.BasicData.DataEntity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "命名空间：";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(129, 72);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(368, 21);
            this.txtNameSpace.TabIndex = 28;
            this.txtNameSpace.Text = "Founder.FIS.CMD.BasicData.DataEntity.DataEntity";
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(428, 19);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(134, 21);
            this.txtModule.TabIndex = 27;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(383, 23);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(41, 12);
            this.lblModule.TabIndex = 26;
            this.lblModule.Text = "模块：";
            // 
            // lblListCol
            // 
            this.lblListCol.AutoSize = true;
            this.lblListCol.Location = new System.Drawing.Point(334, 23);
            this.lblListCol.Name = "lblListCol";
            this.lblListCol.Size = new System.Drawing.Size(17, 12);
            this.lblListCol.TabIndex = 25;
            this.lblListCol.Text = "列";
            // 
            // txtListLayout
            // 
            this.txtListLayout.Location = new System.Drawing.Point(293, 19);
            this.txtListLayout.Name = "txtListLayout";
            this.txtListLayout.Size = new System.Drawing.Size(35, 21);
            this.txtListLayout.TabIndex = 24;
            this.txtListLayout.Text = "3";
            // 
            // lblListLayout
            // 
            this.lblListLayout.AutoSize = true;
            this.lblListLayout.Location = new System.Drawing.Point(197, 23);
            this.lblListLayout.Name = "lblListLayout";
            this.lblListLayout.Size = new System.Drawing.Size(89, 12);
            this.lblListLayout.TabIndex = 23;
            this.lblListLayout.Text = "列表页面布局：";
            // 
            // lblEditCol
            // 
            this.lblEditCol.AutoSize = true;
            this.lblEditCol.Location = new System.Drawing.Point(146, 23);
            this.lblEditCol.Name = "lblEditCol";
            this.lblEditCol.Size = new System.Drawing.Size(17, 12);
            this.lblEditCol.TabIndex = 22;
            this.lblEditCol.Text = "列";
            // 
            // txtEditLayout
            // 
            this.txtEditLayout.Location = new System.Drawing.Point(105, 19);
            this.txtEditLayout.Name = "txtEditLayout";
            this.txtEditLayout.Size = new System.Drawing.Size(35, 21);
            this.txtEditLayout.TabIndex = 21;
            this.txtEditLayout.Text = "1";
            // 
            // lblEditLayout
            // 
            this.lblEditLayout.AutoSize = true;
            this.lblEditLayout.Location = new System.Drawing.Point(9, 23);
            this.lblEditLayout.Name = "lblEditLayout";
            this.lblEditLayout.Size = new System.Drawing.Size(89, 12);
            this.lblEditLayout.TabIndex = 20;
            this.lblEditLayout.Text = "编辑页面布局：";
            // 
            // btnSelectEntityPath
            // 
            this.btnSelectEntityPath.Location = new System.Drawing.Point(503, 44);
            this.btnSelectEntityPath.Name = "btnSelectEntityPath";
            this.btnSelectEntityPath.Size = new System.Drawing.Size(59, 23);
            this.btnSelectEntityPath.TabIndex = 19;
            this.btnSelectEntityPath.Text = "选择";
            this.btnSelectEntityPath.UseVisualStyleBackColor = true;
            this.btnSelectEntityPath.Click += new System.EventHandler(this.btnSelectEntityPath_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(129, 45);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(368, 21);
            this.txtSavePath.TabIndex = 18;
            // 
            // lblEntitySavePath
            // 
            this.lblEntitySavePath.AutoSize = true;
            this.lblEntitySavePath.Location = new System.Drawing.Point(9, 49);
            this.lblEntitySavePath.Name = "lblEntitySavePath";
            this.lblEntitySavePath.Size = new System.Drawing.Size(89, 12);
            this.lblEntitySavePath.TabIndex = 17;
            this.lblEntitySavePath.Text = "文件保存路径：";
            // 
            // lblTableDesc
            // 
            this.lblTableDesc.AutoSize = true;
            this.lblTableDesc.Location = new System.Drawing.Point(34, 63);
            this.lblTableDesc.Name = "lblTableDesc";
            this.lblTableDesc.Size = new System.Drawing.Size(0, 12);
            this.lblTableDesc.TabIndex = 8;
            this.lblTableDesc.Visible = false;
            // 
            // panelMiddle
            // 
            this.panelMiddle.Controls.Add(this.panelMiddleMiddle);
            this.panelMiddle.Controls.Add(this.panelLeft);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(1274, 487);
            this.panelMiddle.TabIndex = 15;
            // 
            // panelMiddleMiddle
            // 
            this.panelMiddleMiddle.Controls.Add(this.panel3);
            this.panelMiddleMiddle.Controls.Add(this.panel2);
            this.panelMiddleMiddle.Controls.Add(this.panel1);
            this.panelMiddleMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddleMiddle.Location = new System.Drawing.Point(189, 0);
            this.panelMiddleMiddle.Name = "panelMiddleMiddle";
            this.panelMiddleMiddle.Size = new System.Drawing.Size(1085, 487);
            this.panelMiddleMiddle.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(13, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 487);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridViewMain);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1058, 487);
            this.panel5.TabIndex = 6;
            // 
            // gridViewMain
            // 
            this.gridViewMain.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.gridViewMain.AllowUserToAddRows = false;
            this.gridViewMain.AllowUserToDeleteRows = false;
            this.gridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnType,
            this.ColumnDesc,
            this.ColumnControlType,
            this.ColumnIsPK,
            this.ColumnIsNullable,
            this.ColumnIsValidate,
            this.ColumnIsEditControl,
            this.ColumnIsQueryFilter,
            this.ColumnIsListControl,
            this.ColumnIsOrderInListPage,
            this.ColumnDefaultSortExpression});
            this.gridViewMain.ContextMenuStrip = this.contextMenuStripGridView;
            this.gridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewMain.Location = new System.Drawing.Point(0, 0);
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.RowTemplate.Height = 23;
            this.gridViewMain.Size = new System.Drawing.Size(1058, 487);
            this.gridViewMain.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "ColumnName";
            this.ColumnName.HeaderText = "字段名称";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.DataPropertyName = "Type";
            this.ColumnType.HeaderText = "字段类型";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.DataPropertyName = "ColumnDesc";
            this.ColumnDesc.HeaderText = "字段描述";
            this.ColumnDesc.Name = "ColumnDesc";
            // 
            // ColumnControlType
            // 
            this.ColumnControlType.HeaderText = "控件类型";
            this.ColumnControlType.MaxDropDownItems = 50;
            this.ColumnControlType.Name = "ColumnControlType";
            this.ColumnControlType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnIsPK
            // 
            this.ColumnIsPK.DataPropertyName = "PrimaryKey";
            this.ColumnIsPK.HeaderText = "是否主键";
            this.ColumnIsPK.Name = "ColumnIsPK";
            this.ColumnIsPK.ReadOnly = true;
            // 
            // ColumnIsNullable
            // 
            this.ColumnIsNullable.DataPropertyName = "NullAble";
            this.ColumnIsNullable.HeaderText = "是否可空";
            this.ColumnIsNullable.Name = "ColumnIsNullable";
            this.ColumnIsNullable.ReadOnly = true;
            // 
            // ColumnIsValidate
            // 
            this.ColumnIsValidate.HeaderText = "验证规则";
            this.ColumnIsValidate.Items.AddRange(new object[] {
            "不可为空",
            "数字",
            "日期",
            "邮箱"});
            this.ColumnIsValidate.Name = "ColumnIsValidate";
            this.ColumnIsValidate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIsValidate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnIsEditControl
            // 
            this.ColumnIsEditControl.HeaderText = "是否在编辑页面显示";
            this.ColumnIsEditControl.Name = "ColumnIsEditControl";
            // 
            // ColumnIsQueryFilter
            // 
            this.ColumnIsQueryFilter.HeaderText = "是否查询条件";
            this.ColumnIsQueryFilter.Name = "ColumnIsQueryFilter";
            // 
            // ColumnIsListControl
            // 
            this.ColumnIsListControl.HeaderText = "是否在列表页面显示";
            this.ColumnIsListControl.Name = "ColumnIsListControl";
            // 
            // ColumnIsOrderInListPage
            // 
            this.ColumnIsOrderInListPage.HeaderText = "是否排序";
            this.ColumnIsOrderInListPage.Name = "ColumnIsOrderInListPage";
            this.ColumnIsOrderInListPage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIsOrderInListPage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnDefaultSortExpression
            // 
            this.ColumnDefaultSortExpression.HeaderText = "默认排序字段";
            this.ColumnDefaultSortExpression.Name = "ColumnDefaultSortExpression";
            // 
            // contextMenuStripGridView
            // 
            this.contextMenuStripGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GridViewToolStripMenuItemRefersh});
            this.contextMenuStripGridView.Name = "contextMenuStripGridView";
            this.contextMenuStripGridView.Size = new System.Drawing.Size(101, 26);
            // 
            // GridViewToolStripMenuItemRefersh
            // 
            this.GridViewToolStripMenuItemRefersh.Name = "GridViewToolStripMenuItemRefersh";
            this.GridViewToolStripMenuItemRefersh.Size = new System.Drawing.Size(100, 22);
            this.GridViewToolStripMenuItemRefersh.Text = "刷新";
            this.GridViewToolStripMenuItemRefersh.Click += new System.EventHandler(this.GridViewToolStripMenuItemRefersh_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 487);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1071, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 487);
            this.panel1.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panel6);
            this.panelLeft.Controls.Add(this.panel4);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(189, 487);
            this.panelLeft.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listBoxTableName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(189, 460);
            this.panel6.TabIndex = 1;
            // 
            // listBoxTableName
            // 
            this.listBoxTableName.AllowDrop = true;
            this.listBoxTableName.ContextMenuStrip = this.contextMenuStripTableName;
            this.listBoxTableName.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTableName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTableName.FormattingEnabled = true;
            this.listBoxTableName.HorizontalScrollbar = true;
            this.listBoxTableName.ItemHeight = 19;
            this.listBoxTableName.Location = new System.Drawing.Point(0, 0);
            this.listBoxTableName.Name = "listBoxTableName";
            this.listBoxTableName.Size = new System.Drawing.Size(189, 460);
            this.listBoxTableName.TabIndex = 11;
            this.listBoxTableName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTableName_MouseClick);
            this.listBoxTableName.SelectedIndexChanged += new System.EventHandler(this.listBoxTableName_SelectedIndexChanged);
            // 
            // contextMenuStripTableName
            // 
            this.contextMenuStripTableName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRefersh});
            this.contextMenuStripTableName.Name = "contextMenuStripTableName";
            this.contextMenuStripTableName.Size = new System.Drawing.Size(101, 26);
            this.contextMenuStripTableName.Text = "操作";
            // 
            // ToolStripMenuItemRefersh
            // 
            this.ToolStripMenuItemRefersh.Name = "ToolStripMenuItemRefersh";
            this.ToolStripMenuItemRefersh.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemRefersh.Text = "刷新";
            this.ToolStripMenuItemRefersh.Click += new System.EventHandler(this.ToolStripMenuItemRefersh_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblFiliter);
            this.panel4.Controls.Add(this.txtFiliter);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 27);
            this.panel4.TabIndex = 0;
            // 
            // lblFiliter
            // 
            this.lblFiliter.AutoSize = true;
            this.lblFiliter.Location = new System.Drawing.Point(6, 7);
            this.lblFiliter.Name = "lblFiliter";
            this.lblFiliter.Size = new System.Drawing.Size(29, 12);
            this.lblFiliter.TabIndex = 1;
            this.lblFiliter.Text = "筛选";
            // 
            // txtFiliter
            // 
            this.txtFiliter.Location = new System.Drawing.Point(36, 3);
            this.txtFiliter.Name = "txtFiliter";
            this.txtFiliter.Size = new System.Drawing.Size(147, 21);
            this.txtFiliter.TabIndex = 0;
            this.txtFiliter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiliter_KeyUp);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "E:\\Work\\CMD2.0\\实体";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 625);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "页面生成工具";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.radionButtonPanel.ResumeLayout(false);
            this.radionButtonPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.panelMiddleMiddle.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.contextMenuStripGridView.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.contextMenuStripTableName.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelMiddleMiddle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ListBox listBoxTableName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.DataGridView gridViewMain;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTableDesc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblListCol;
        private System.Windows.Forms.TextBox txtListLayout;
        private System.Windows.Forms.Label lblListLayout;
        private System.Windows.Forms.Label lblEditCol;
        private System.Windows.Forms.TextBox txtEditLayout;
        private System.Windows.Forms.Label lblEditLayout;
        private System.Windows.Forms.Button btnSelectEntityPath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label lblEntitySavePath;
        private System.Windows.Forms.CheckBox chkListPage;
        private System.Windows.Forms.CheckBox chkEditPage;
        private System.Windows.Forms.CheckBox chkEntity;
        private System.Windows.Forms.Button btnListQuerySQL;
        private System.Windows.Forms.CheckBox chkExport;
        private System.Windows.Forms.CheckBox chkLogic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label lblAssembly;
        private System.Windows.Forms.TextBox txtAssembly;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnControlType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsNullable;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnIsValidate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsEditControl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsQueryFilter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsListControl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsOrderInListPage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDefaultSortExpression;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTableName;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRefersh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGridView;
        private System.Windows.Forms.ToolStripMenuItem GridViewToolStripMenuItemRefersh;
        private System.Windows.Forms.RadioButton radioButtonCommon;
        private System.Windows.Forms.RadioButton radioButtonBasic;
        private System.Windows.Forms.Panel radionButtonPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFiliter;
        private System.Windows.Forms.TextBox txtFiliter;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnGenerateTable;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

