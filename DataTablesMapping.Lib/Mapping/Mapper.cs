using DataTablesMapping.Lib.Attributes;
using DataTablesMapping.Lib.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMapping.Lib.Mapping
{
    public class Mapper<TEntity> where TEntity : class, new()
    {
        public List<TEntity> Map(DataTable table)
        {
            List<TEntity> entities = new List<TEntity>();
            var columnNames = table.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();
            var properties = (typeof(TEntity)).GetProperties()
                                              .Where(x => x.GetCustomAttributes(typeof(SourceNamesAttribute), true).Any())
                                              .ToList(); //Only get properties that have the SourceNamesAttribute; ignore others
            foreach (DataRow row in table.Rows)
            {
                TEntity entity = new TEntity();
                foreach (var prop in properties)
                {
                    Map(typeof(TEntity), row, prop, entity);
                }
                entities.Add(entity);
            }

            return entities;
        }

        public void Map(Type type, DataRow row, PropertyInfo prop, object entity)
        {
            List<string> columnNames = MappingHelper.GetSourceNames(type, prop.Name);
            //Handle .NET Primitives and Structs (e.g. DateTime) here.
            foreach (var columnName in columnNames)
            {
                if (!String.IsNullOrWhiteSpace(columnName) && row.Table.Columns.Contains(columnName))
                {
                    var propertyValue = row[columnName];
                    if (propertyValue != DBNull.Value)
                    {
                        MappingHelper.ParsePrimitive(prop, entity, row[columnName]);
                        break; //Assumes that the first matching column contains the source data
                    }
                }
            }
        }
    }
}
