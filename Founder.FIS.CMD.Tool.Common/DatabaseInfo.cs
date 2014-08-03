using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.Common
{
    public static class DatabaseInfo
    {
        /// <summary>
        /// 数据库类型
        /// </summary>
        public static EnumDatabaseType DBType { get; set; }

        /// <summary>
        /// 服务器
        /// </summary>
        public static string DBServer { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public static string DBUser { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public static string DBPwd { get; set; }

        /// <summary>
        /// 数据库
        /// </summary>
        public static string DBCatalog { get; set; }

        public static string GetConnString()
        {
            return "Data Source=" + DBServer + ";Initial Catalog=" + DBCatalog + ";User ID=" + DBUser + ";Password=" + DBPwd;
        }
    }
}
