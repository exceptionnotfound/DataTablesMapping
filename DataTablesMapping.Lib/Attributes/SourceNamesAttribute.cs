using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMapping.Lib.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SourceNamesAttribute : Attribute
    {
        protected List<string> _columnNames { get; set; }

        public List<string> ColumnNames
        {
            get
            {
                return _columnNames;
            }
            set
            {
                _columnNames = value;
            }
        }

        public SourceNamesAttribute()
        {
            _columnNames = new List<string>();
        }

        public SourceNamesAttribute(params string[] columnNames)
        {
            _columnNames = columnNames.ToList();
        }
    }
}
