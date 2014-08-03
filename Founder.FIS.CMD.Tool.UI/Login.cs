using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Founder.FIS.CMD.Tool.BusinessLogic;
using Founder.FIS.CMD.Tool.Common;
using Founder.FIS.CMD.Tool.UI.Common;

namespace Founder.FIS.CMD.Tool.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            EnumDatabaseType dbType = (EnumDatabaseType)Enum.Parse(typeof(EnumDatabaseType), this.cbDBType.SelectedValue.ToString());
            if (Convert.ToInt32(dbType) == -1)
            {
                MessageBox.Show("请选择数据库类型！");
                this.cbDBType.Focus();
                return;
            }
            string server = this.txtServer.Text.Trim();
            if (string.IsNullOrEmpty(server))
            {
                MessageBox.Show("请填写服务器名称！");
                this.txtServer.Focus();
                return;
            }
            string user = this.txtUser.Text.Trim();
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("请填写用户名！");
                this.txtUser.Focus();
                return;
            }
            string pwd = this.txtPwd.Text.Trim();
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("请填写密码！");
                this.txtPwd.Focus();
                return;
            }
            string catalog = this.txtCatalog.Text.Trim();
            if (string.IsNullOrEmpty(catalog))
            {
                MessageBox.Show("请填写数据库名称！");
                this.txtCatalog.Focus();
                return;
            }
            string connStr = "Data Source=" + server + ";Initial Catalog=" + catalog + ";User ID=" + user + ";Password=" + pwd;
            LoginBLL loginBLL = new LoginBLL();
            if (loginBLL.CheckLogin(connStr, dbType))
            {
                DatabaseInfo.DBType = dbType;
                DatabaseInfo.DBServer = server;
                DatabaseInfo.DBUser = user;
                DatabaseInfo.DBPwd = pwd;
                DatabaseInfo.DBCatalog = catalog;
                saveConnConfig();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("数据库连接信息有误，请重新输入！", "重新登陆");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 初始化控件
        private void InitControls()
        {
            cbDBType.DataSource = FormHelper.GetListViaEnum(typeof(EnumDatabaseType));
            cbDBType.ValueMember = "Value";
            cbDBType.DisplayMember = "Name";
            cbDBType.SelectedValue = -1;

            //读取配置文件值
            SetControlValue();
        }

        /// <summary>
        /// 通过配置文件设置控件值
        /// </summary>
        private void SetControlValue()
        {
            string dbType = ConfigurationManager.AppSettings["DBType"];
            string dbServer = ConfigurationManager.AppSettings["DBServer"];
            string dbUser = ConfigurationManager.AppSettings["DBUser"];
            string dbPwd = ConfigurationManager.AppSettings["DBPwd"];
            string dbCatalog = ConfigurationManager.AppSettings["DBCatalog"];
            string isLogPwd = ConfigurationManager.AppSettings["IsLogPwd"];
            string isAutoLogin = ConfigurationManager.AppSettings["IsAutoLogin"];
            if (!string.IsNullOrEmpty(dbType))
            {
                this.cbDBType.SelectedValue = dbType;
            }
            if (!string.IsNullOrEmpty(dbServer))
            {
                this.txtServer.Text = dbServer;
            }
            if (!string.IsNullOrEmpty(dbUser))
            {
                this.txtUser.Text = dbUser;
            }
            if (isLogPwd == "Y")
            {
                this.chkLogPwd.Checked = true;
                if (!string.IsNullOrEmpty(dbPwd))
                {
                    this.txtPwd.Text = dbPwd;
                }
            }
            if (isAutoLogin == "Y")
            {
                this.chkAutoLogin.Checked = true;
            }
            if (!string.IsNullOrEmpty(dbCatalog))
            {
                this.txtCatalog.Text = dbCatalog;
            }
        }
        #endregion


        private void Login_Load(object sender, EventArgs e)
        {
            InitControls();
            autoLogin();
        }

        private void autoLogin()
        {
            string isAutoLogin = ConfigurationManager.AppSettings["IsAutoLogin"];
            if (isAutoLogin == "Y")
            {
                login();
            }
        }

        /// <summary>
        /// 保存信息到配置文件
        /// </summary>
        private void saveConnConfig()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string dbType = config.AppSettings.Settings["DBType"].Value;
            bool isUpdate = false;
            if (dbType != DatabaseInfo.DBType.ToString())
            {
                config.AppSettings.Settings["DBType"].Value = Convert.ToString((int)DatabaseInfo.DBType);
                isUpdate = true;
            }
            string dbServer = config.AppSettings.Settings["DBServer"].Value;
            if (dbServer != DatabaseInfo.DBServer)
            {
                config.AppSettings.Settings["DBServer"].Value = DatabaseInfo.DBServer;
                isUpdate = true;
            }
            string dbUser = config.AppSettings.Settings["DBUser"].Value;
            if (dbUser != DatabaseInfo.DBUser)
            {
                config.AppSettings.Settings["DBUser"].Value = DatabaseInfo.DBUser;
                isUpdate = true;
            }
            string dbPwd = config.AppSettings.Settings["DBPwd"].Value;
            if (dbPwd != DatabaseInfo.DBPwd)
            {
                config.AppSettings.Settings["DBPwd"].Value = DatabaseInfo.DBPwd;
                isUpdate = true;
            }
            string dbCatalog = config.AppSettings.Settings["DBCatalog"].Value;
            if (dbCatalog != DatabaseInfo.DBCatalog)
            {
                config.AppSettings.Settings["DBCatalog"].Value = DatabaseInfo.DBCatalog;
                isUpdate = true;
            }
            bool isLogPwd = config.AppSettings.Settings["IsLogPwd"].Value == "Y" ? true : false;
            if (isLogPwd != chkLogPwd.Checked)
            {
                config.AppSettings.Settings["IsLogPwd"].Value = chkLogPwd.Checked ? "Y" : "N";
                isUpdate = true;
            }
            bool isAutoLogin = config.AppSettings.Settings["IsAutoLogin"].Value == "Y" ? true : false;
            if (isAutoLogin != chkAutoLogin.Checked)
            {
                config.AppSettings.Settings["IsAutoLogin"].Value = chkAutoLogin.Checked ? "Y" : "N";
                isUpdate = true;
            }
            if (isUpdate)
            {
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }


    }
}
