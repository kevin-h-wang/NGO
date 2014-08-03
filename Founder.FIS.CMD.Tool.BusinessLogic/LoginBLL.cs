using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Founder.FIS.CMD.Tool.Common;
using Founder.FIS.CMD.Tool.DataAccess;

namespace Founder.FIS.CMD.Tool.BusinessLogic
{
    public class LoginBLL
    {
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="connStr">连接字符串</param>
        /// <param name="dbType">数据库类型</param>
        /// <returns></returns>
        public bool CheckLogin(string connStr, EnumDatabaseType dbType)
        {
            IDataAccess dataAccess = DataAccessFactory.CreateInstance(connStr, dbType);
            try
            {
                object result = dataAccess.ExecuteScalar("SELECT 1");
                if (result != null && (Convert.ToInt32(result) == 1))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
