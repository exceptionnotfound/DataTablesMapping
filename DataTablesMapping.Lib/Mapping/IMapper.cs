using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMapping.Lib.Mapping
{
    public interface IMapper<T>
    {
        List<T> Map(DataTable table);
    }
}
