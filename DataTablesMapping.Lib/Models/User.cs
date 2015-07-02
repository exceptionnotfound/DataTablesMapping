using DataTablesMapping.Lib.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMapping.Lib.Models
{
    public class User
    {
        [SourceNames("user_id", "userId")]
        public int ID { get; set; }

        [SourceNames("first_name", "first")]
        public string FirstName { get; set; }

        [SourceNames("last_name", "last")]
        public string LastName { get; set; }

        [SourceNames("date_of_birth", "birthDate")]
        public DateTime? DateOfBirth { get; set; }

        [SourceNames("cash_on_hand", "cash", "cashOnHand")]
        public decimal CashOnHand { get; set; }
    }
}
