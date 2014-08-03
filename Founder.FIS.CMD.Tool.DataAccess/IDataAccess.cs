using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.DataAccess
{
    /// <summary>
    /// 数据访问接口
    /// 编写日期：2012-4-20
    /// </summary>
    public interface IDataAccess
    {
        /// <summary>
        /// 执行返回处理影响行数、不返回结果集的SQL语句（如INSERT、UPDATE、DELETE）
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="paramsList">参数数组</param>
        /// <param name="commandType">SQL语句类型(可为SQL文本、存储过程、表名)，默认值为CommandType.Text</param>
        /// <returns>执行影响的记录行数</returns>
        int ExecuteNonQuery(string sql, List<IDbDataParameter> paramsList = null, CommandType commandType = CommandType.Text);

        /// <summary>
        /// 批量执行语句
        /// </summary>
        /// <param name="commands"></param>
        void ExecuteNonQuery(List<IDbCommand> commands);
        /// <summary>
        /// 执行后返回结果记录集的第一行第一列
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="paramsList">参数数组</param>
        /// <param name="commandType">SQL语句类型(可为SQL文本、存储过程、表名)，默认值为CommandType.Text</param>
        /// <returns>结果记录集的第一行第一列</returns>
        Object ExecuteScalar(string sql, List<IDbDataParameter> paramsList = null, CommandType commandType = CommandType.Text);
        /// <summary>
        /// 执行返回DataTable类型数据集的SQL查询（SELECT）
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="paramsList">参数数组</param>
        /// <param name="commandType">SQL语句类型(可为SQL文本、存储过程、表名)，默认值为CommandType.Text</param>
        /// <returns>查询结果DataTable</returns>
        DataTable Fill(string sql, List<IDbDataParameter> paramsList = null, CommandType commandType = CommandType.Text);

        /// <summary>
        /// 执行填充DataSet数据集的SQL查询（SELECT）
        /// </summary>
        /// <param name="dataSet">要填充的DataSet</param>
        /// <param name="sql">SQL语句</param>
        /// <param name="paramsList">参数数组</param>
        /// <param name="commandType">SQL语句类型(可为SQL文本、存储过程、表名)，默认值为CommandType.Text</param>
        void Fill(DataSet dataSet, string sql, List<IDbDataParameter> paramsList = null, CommandType commandType = CommandType.Text);

        /// <summary>
        /// 执行返回DataTable类型数据集的SQL查询（SELECT）不参与事务
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="paramsList">参数数组</param>
        /// <param name="commandType">SQL语句类型(可为SQL文本、存储过程、表名)</param>
        /// <returns>查询结果DataTable</returns>
        DataTable TransactionSuppressFill(string sql, List<IDbDataParameter> paramsList = null,
                                     CommandType commandType = CommandType.Text);
        /// <summary>
        /// 获取IDbDataParameter实例
        /// </summary>
        /// <returns></returns>
        IDbDataParameter GetParameter();

        /// <summary>
        /// 根据字段名生成IDbDataParameter对象的ParameterName
        /// </summary>
        /// <param name="fieldName">字段名</param>
        /// <returns></returns>
        string GetParameterName(string fieldName);

        /// <summary>
        /// 根据字段名和字段值生成IDbDataParameter对象
        /// </summary>
        /// <param name="fieldName">字段名</param>
        /// <param name="fieldValue">字段值</param>
        /// <returns></returns>
        IDbDataParameter GetParameter(string fieldName, object fieldValue);
    }
}
