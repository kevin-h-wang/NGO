using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.UI.Common
{
    /// <summary>
    /// 生成页面信息类
    /// </summary>
    public class GenerateInfo
    {
        /// <summary>
        /// 表名
        /// </summary>
        public virtual string TableName { get; set; }
        /// <summary>
        /// 表描述
        /// </summary>
        public virtual string TableDesc { get; set; }
        /// <summary>
        /// 编辑页面列数
        /// </summary>
        public virtual int EditColumnNumber { get; set; }
        /// <summary>
        /// 列表页面查询条件列数
        /// </summary>
        public virtual int ListColumnNumber { get; set; }
        /// <summary>
        /// 模块名
        /// </summary>
        public virtual string Module { get; set; }
        /// <summary>
        /// 保存路径
        /// </summary>
        public virtual string SavePath { get; set; }
        /// <summary>
        /// 是否支持导出
        /// </summary>
        public virtual bool IsCanExport { get; set; }
        /// <summary>
        /// 命名空间
        /// </summary>
        public virtual string NameSpace { get; set; }
        /// <summary>
        /// 程序集
        /// </summary>
        public virtual string Assembly { get; set; }
        /// <summary>
        /// 实体名称
        /// </summary>
        public virtual string EntityName { get; set; }
    }
}
