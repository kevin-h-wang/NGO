using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.FIS.CMD.Tool.UI.Common
{
    /// <summary>
    /// 列表项
    /// </summary>
    [Serializable]
    public class ListItem
    {
        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public virtual object Value { get; set; }

        public ListItem() { }

        public ListItem(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}
