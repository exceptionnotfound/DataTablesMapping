using DataTablesMapping.Lib;
using DataTablesMapping.Lib.Mapping;
using DataTablesMapping.Lib.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTablesMapping.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult FirstSet()
        {
            DataTable table = DataTableGenerator.GetFirstTable();
            Mapper<User> mapper = new Mapper<User>();
            IEnumerable<User> users = mapper.Map(table);
            return View(users);
        }

        [HttpGet]
        public ActionResult SecondSet()
        {
            DataTable table = DataTableGenerator.GetSecondTable();
            Mapper<User> mapper = new Mapper<User>();
            IEnumerable<User> users = mapper.Map(table);
            return View(users);
        }

        [HttpGet]
        public ActionResult AllUsers()
        {
            DataTable firstTable = DataTableGenerator.GetFirstTable();
            DataTable secondTable = DataTableGenerator.GetSecondTable();
            Mapper<User> mapper = new Mapper<User>();
            List<User> users = mapper.Map(firstTable);
            users.AddRange(mapper.Map(secondTable));
            return View(users);
        }
    }
}