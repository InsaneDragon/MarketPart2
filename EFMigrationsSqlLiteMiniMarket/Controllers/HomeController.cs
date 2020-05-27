using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFMigrationsSqlLiteMiniMarket.Models;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Data.Sqlite;
using Dapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EFMigrationsSqlLiteMiniMarket.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new SqliteConnection("Data Source=myDB.db"))
            {
                var Cattegories = context.Query<Cattegories>("select * from Cattegories").ToList();
                ViewBag.Cattegories = new SelectList(Cattegories.ToList(), "Id", "Name").ToList() ;
                var Products = from item in context.Query<Product>("select * from Products")
                               select new ViewProduct { Cattegory = Cattegories.Where(x => x.Id == item.Cattegory).FirstOrDefault().Name, Name = item.Name, Id = item.Id, Price = item.Price };
                return View(Products.ToList());
            }
        }
    }
}
