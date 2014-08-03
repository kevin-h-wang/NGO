namespace Founder.FIS.CMD.Tool.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtCatalog = new System.Windows.Forms.TextBox();
            this.lblCatalog = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.cbDBType = new System.Windows.Forms.ComboBox();
            this.lblDBType = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkLogPwd = new System.Windows.Forms.CheckBox();
            this.chkAutoLogin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtCatalog
            // 
            this.txtCatalog.Location = new System.Drawing.Point(107, 176);
            this.txtCatalog.Name = "txtCatalog";
            this.txtCatalog.Size = new System.Drawing.Size(121, 21);
            this.txtCatalog.TabIndex = 19;
            // 
            // lblCatalog
            // 
            this.lblCatalog.AutoSize = true;
            this.lblCatalog.Location = new System.Drawing.Point(53, 180);
            this.lblCatalog.Name = "lblCatalog";
            this.lblCatalog.Size = new System.Drawing.Size(47, 12);
            this.lblCatalog.TabIndex = 18;
            this.lblCatalog.Text = "数据库:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(107, 138);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(121, 21);
            this.txtPwd.TabIndex = 17;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(65, 142);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(35, 12);
            this.lblPwd.TabIndex = 16;
            this.lblPwd.Text = "密码:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(107, 100);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(121, 21);
            this.txtUser.TabIndex = 15;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(53, 104);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 12);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "用户名:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(107, 60);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(121, 21);
            this.txtServer.TabIndex = 13;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(53, 64);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(47, 12);
            this.lblServer.TabIndex = 12;
            this.lblServer.Text = "服务器:";
            // 
            // cbDBType
            // 
            this.cbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBType.FormattingEnabled = true;
            this.cbDBType.Location = new System.Drawing.Point(107, 21);
            this.cbDBType.Name = "cbDBType";
            this.cbDBType.Size = new System.Drawing.Size(121, 20);
            this.cbDBType.TabIndex = 11;
            // 
            // lblDBType
            // 
            this.lblDBType.AutoSize = true;
            this.lblDBType.Location = new System.Drawing.Point(29, 25);
            this.lblDBType.Name = "lblDBType";
            this.lblDBType.Size = new System.Drawing.Size(71, 12);
            this.lblDBType.TabIndex = 10;
            this.lblDBType.Text = "选择数据库:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(55, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(60, 23);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(158, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkLogPwd
            // 
            this.chkLogPwd.AutoSize = true;
            this.chkLogPwd.Location = new System.Drawing.Point(55, 208);
            this.chkLogPwd.Name = "chkLogPwd";
            this.chkLogPwd.Size = new System.Drawing.Size(72, 16);
            this.chkLogPwd.TabIndex = 22;
            this.chkLogPwd.Text = "记住密码";
            this.chkLogPwd.UseVisualStyleBackColor = true;
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.AutoSize = true;
            this.chkAutoLogin.Location = new System.Drawing.Point(158, 208);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(72, 16);
            this.chkAutoLogin.TabIndex = 23;
            this.chkAutoLogin.Text = "自动登录";
            this.chkAutoLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 267);
            this.Controls.Add(this.chkAutoLogin);
            this.Controls.Add(this.chkLogPwd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtCatalog);
            this.Controls.Add(this.lblCatalog);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.cbDBType);
            this.Controls.Add(this.lblDBType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatalog;
        private System.Windows.Forms.Label lblCatalog;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cbDBType;
        private System.Windows.Forms.Label lblDBType;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkLogPwd;
        private System.Windows.Forms.CheckBox chkAutoLogin;
    }
}