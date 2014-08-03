using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.DataAccess
{
    /// <summary>
    /// 目的：SQL Server数据库访问实现类
    /// 编写日期：2012-4-20
    /// </summary>
    internal class SqlDataAccess : DataAccess
    {
        protected readonly string ConnectionString;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        public SqlDataAccess(string connectionString)
        //: base(connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary>
        /// 初始化DbConnection对象
        /// </summary>
        protected override DbConnection GetConnection
        {
            get { return new SqlConnection(ConnectionString); }
        }

        /// <summary>
        /// 初始化DbCommand对象
        /// </summary>
        protected override DbCommand GetCommand
        {
            get { return new SqlCommand(); }
        }

        /// <summary>
        /// 初始化DbDataAdapter对象
        /// </summary>
        protected override DbDataAdapter GetDataAdapter
        {
            get { return new SqlDataAdapter(); }
        }

        /// <summary>
        /// 获取IDbDataParameter实例
        /// </summary>
        /// <returns></returns>
        public override IDbDataParameter GetParameter()
        {
            return new SqlParameter();
        }

        /// <summary>
        /// 根据字段名生成IDbDataParameter对象的ParameterName
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public override string GetParameterName(string fieldName)
        {
            return string.Format("@{0}", fieldName);
        }

        /// <summary>
        /// 根据字段名和字段值生成IDbDataParameter对象
        /// </summary>
        /// <param name="fieldName">字段名</param>
        /// <param name="fieldValue">字段值</param>
        /// <returns></returns>
        public override IDbDataParameter GetParameter(string fieldName, object fieldValue)
        {
            var param = new SqlParameter { ParameterName = GetParameterName(fieldName), Value = fieldValue };
            return param;
        }
    }
}
