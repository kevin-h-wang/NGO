using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Founder.FIS.CMD.Tool.DataAccess
{
    /// <summary>
    /// 数据访问基类
    /// 2012-4-20
    /// </summary>
    internal abstract class DataAccess : IDataAccess
    {

        /// <summary>
        /// 初始化DbConnection对象
        /// </summary>
        protected abstract DbConnection GetConnection { get; }

        /// <summary>
        /// 初始化DbCommand对象
        /// </summary>
        protected abstract DbCommand GetCommand { get; }

        /// <summary>
        /// 初始化DbDataAdapter对象
        /// </summary>
        protected abstract DbDataAdapter GetDataAdapter { get; }


        #region IDataAccess Members

        /// <summary>
        /// 执行返回处理影响行数、不返回结果集的SQL语句（如INSERT、UPDATE、DELETE）
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="paramsList">参数数组</param>
        /// <param name="commandType">SQL语句类型(可为SQL文本、存储过程、表名)</param>
        /// <returns>执行影响的记录行数</returns>
        public int ExecuteNonQuery(string sql, List<IDbDataParameter> paramsList = null,
                                   CommandType commandType = CommandType.Text)
        {
            //try
            //{
            using (DbConnection connection = GetConnection)
            {
                int affectRows;
                using (DbCommand command = GetCommand)
                {
                    command.Connection = connection;
                    connection.Open();
                    BuildCommand(command, sql, paramsList, commandType);
                    affectRows = command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                return affectRows;
            }

            //}
            //finally
            //{
            //    Close();
            //}
        }

        public void ExecuteNonQuery(List<IDbCommand> commands)
        {
            using (DbConnection connection = GetConnection)
            {
                if (commands != null)
                {
                    connection.Open();
                    foreach (IDbCommand dbCommand in commands)
                    {
                        dbCommand.Connection = connection;
                        dbCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        public object ExecuteScalar(string sql, List<IDbDataParameter> paramsList = null,
                                    CommandType commandType = CommandType.Text)
        {
            //try
            //{
            using (DbConnection connection = GetConnection)
            {
                object obj;
                using (DbCommand command = GetCommand)
                {
                    command.Connection = connection;
                    connection.Open();
                    BuildCommand(command, sql, paramsList, commandType);
                    obj = command.ExecuteScalar();
                    command.Parameters.Clear();
                }
                return obj;
            }
            //}
            //finally
            //{
            //    Close();
            //}
        }

        /// <summary>
        /// 执行返回DataTable类型数据集的SQL查询（SELECT）
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="paramsList">参数数组</param>
        /// <param name="commandType">SQL语句类型(可为SQL文本、存储过程、表名)</param>
        /// <returns>查询结果DataTable</returns>
        public DataTable Fill(string sql, List<IDbDataParameter> paramsList = null,
                              CommandType commandType = CommandType.Text)
        {
            //try
            //{
            using (DbConnection connection = GetConnection)
            {
                DataTable dataTable;
                DbDataAdapter dataAdapter;
                using (DbCommand command = GetCommand)
                {
                    command.Connection = connection;
                    connection.Open();
                    BuildCommand(command, sql, paramsList, commandType);
                    dataTable = new DataTable();
                    dataAdapter = GetDataAdapter;
                    dataAdapter.SelectCommand = command;

                    //Open();
                    dataAdapter.Fill(dataTable);
                    command.Parameters.Clear();
                    return dataTable;
                }
            }
            //}
            //finally
            //{
            //    Close();
            //}
        }

        /// <summary>
        /// 执行返回DataTable类型数据集的SQL查询（SELECT）
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="paramsList">参数数组</param>
        /// <param name="commandType">SQL语句类型(可为SQL文本、存储过程、表名)</param>
        /// <returns>查询结果DataTable</returns>
        public DataTable TransactionSuppressFill(string sql, List<IDbDataParameter> paramsList = null,
                              CommandType commandType = CommandType.Text)
        {
            //try
            //{
            using (DbConnection connection = GetConnection)
            {
                using (DbCommand command = GetCommand)
                {
                    DataTable dataTable;
                    command.Connection = connection;
                    connection.Open();
                    using (var scope = new TransactionScope(TransactionScopeOption.Suppress))
                    {

                        BuildCommand(command, sql, paramsList, commandType);
                        dataTable = new DataTable();
                        DbDataAdapter dataAdapter = GetDataAdapter;
                        dataAdapter.SelectCommand = command;

                        //Open();
                        dataAdapter.Fill(dataTable);
                        command.Parameters.Clear();
                        scope.Complete();
                    }
                    return dataTable;
                }
            }
            //}
            //finally
            //{
            //    Close();
            //}
        }
        /// <summary>
        /// 执行填充DataSet数据集的SQL查询（SELECT）
        /// </summary>
        /// <param name="dataSet">要填充的DataSet</param>
        /// <param name="sql">SQL语句</param>
        /// <param name="paramsList">参数数组</param>
        /// <param name="commandType">SQL语句类型(可为SQL文本、存储过程、表名)</param>
        public void Fill(DataSet dataSet, string sql, List<IDbDataParameter> paramsList = null,
                         CommandType commandType = CommandType.Text)
        {
            //try
            //{
            using (DbConnection connection = GetConnection)
            {
                DbDataAdapter dataAdapter;
                using (DbCommand command = GetCommand)
                {
                    command.Connection = connection;
                    connection.Open();
                    BuildCommand(command, sql, paramsList, commandType);
                    if (dataSet == null)
                    {
                        dataSet = new DataSet();
                    }
                    dataAdapter = GetDataAdapter;
                    dataAdapter.SelectCommand = command;
                    command.Parameters.Clear();
                }
                //Open();
                dataAdapter.Fill(dataSet);

            }
            //}
            //finally
            //{
            //    Close();
            //}
        }

        /// <summary>
        /// 获取IDbDataParameter实例
        /// </summary>
        /// <returns></returns>
        public abstract IDbDataParameter GetParameter();

        /// <summary>
        /// 根据字段名生成IDbDataParameter对象的ParameterName
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public abstract string GetParameterName(string fieldName);

        /// <summary>
        /// 根据字段名和字段值生成IDbDataParameter对象
        /// </summary>
        /// <param name="fieldName">字段名</param>
        /// <param name="fieldValue">字段值</param>
        /// <returns></returns>
        public abstract IDbDataParameter GetParameter(string fieldName, object fieldValue);

        #endregion

        /// <summary>
        /// 根据SQL语句和参数数组构造可执行的IDbCommand对象
        /// </summary>
        /// <param name="dbCommand"></param>
        /// <param name="sql"></param>
        /// <param name="paramsList"></param>
        /// <param name="commandType"></param>
        private void BuildCommand(IDbCommand dbCommand, string sql, IEnumerable<IDbDataParameter> paramsList,
                                  CommandType commandType)
        {
            dbCommand.CommandType = commandType;
            dbCommand.CommandText = sql;

            if (dbCommand.Parameters.Count > 0)
            {
                dbCommand.Parameters.Clear();
            }

            if (paramsList != null)
            {
                foreach (IDbDataParameter param in paramsList)
                {
                    dbCommand.Parameters.Add(param);
                }
            }
        }
    }
}
