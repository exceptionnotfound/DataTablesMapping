using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMapping.Lib
{
    public static class DataTableGenerator
    {
        public static DataTable GetFirstTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("first_name"));
            table.Columns.Add(new DataColumn("last_name"));
            table.Columns.Add(new DataColumn("date_of_birth"));
            table.Columns.Add(new DataColumn("user_id"));
            table.Columns.Add(new DataColumn("cash_on_hand"));

            table.Rows.Add("Jack", "Jones", new DateTime(1975, 1, 24), 1, 28.10M);
            table.Rows.Add("Margaret", "Porter", new DateTime(1967, 6, 2), 2, 30M);
            table.Rows.Add("Edvard", "Vilkinic", new DateTime(1923, 11, 14), 3, 0);
            table.Rows.Add("Consuela", "Villalobos", null, 4, 12M);
            table.Rows.Add("Harvey", "Jackson", new DateTime(1966, 8, 20), 5, 47.65M);
            table.Rows.Add("Jilka", "Severanovic", new DateTime(1988, 3, 22), 6, 138.22M);

            return table;
        }

        public static DataTable GetSecondTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("first"));
            table.Columns.Add(new DataColumn("last"));
            table.Columns.Add(new DataColumn("birthDate"));
            table.Columns.Add(new DataColumn("userId"));
            table.Columns.Add(new DataColumn("cash"));

            table.Rows.Add("Mark", "Rollins", new DateTime(1972, 10, 9), 7, 50M);
            table.Rows.Add("Anita", "Davis", null, 8, 43.9M);
            table.Rows.Add("Augustine", "Lopez", new DateTime(1983, 12, 25), 9, 12M);
            table.Rows.Add("Takahashi", "Miyamoto", null, 10, 20M);
            table.Rows.Add("Zhen Sui", "Phong", new DateTime(2001, 7, 29), 11, 109.75M);
            table.Rows.Add("Zehiyan", "Saardos", new DateTime(1993, 4, 25), 12, 120.25M);

            return table;
        }
    }
}
