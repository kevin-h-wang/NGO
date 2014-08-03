using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Founder.FIS.CMD.Tool.Common;

namespace Founder.FIS.CMD.Tool.DataAccess
{
    /// <summary>
    /// 目的：数据访问工厂类
    /// 编写日期：2012-4-20
    /// </summary>
    public static class DataAccessFactory
    {
        /// <summary>
        /// 返回数据访问类实例
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="databaseType">数据库类型，默认值为EnumDatabaseType.SQLServer</param>
        /// <returns>IDataAccess实例</returns>
        public static IDataAccess CreateInstance(string connectionString, EnumDatabaseType databaseType = EnumDatabaseType.SQLServer)
        {
            switch (databaseType)
            {
                case EnumDatabaseType.SQLServer:
                    return new SqlDataAccess(connectionString);
                default:
                    return null;
            }
        }
    }
}
