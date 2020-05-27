using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Dapper;
using EFMigrationsSqlLiteMiniMarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace EFMigrationsSqlLiteMiniMarket.Controllers
{
    public class ActionsController : Controller
    {
        public JsonResult AddProduct(string Name, double? Price, int? Cattegory)
        {
            using (var context = new SqliteConnection("Data Source=myDB.db"))
            {
                if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Price.ToString()) || string.IsNullOrEmpty(Cattegory.ToString()))
                {
                    return Json("Please fill all fields");
                }
                try
                {
                    context.Open();
                    context.Query($"insert into Products(Name,Cattegory,Price)values('{Name}',{Cattegory},{Price})");
                    var Products = context.Query<Product>("select * from Products");
                    var Cattegories = context.Query<Cattegories>("select * from Cattegories").ToList();
                    var p = Products.Max(x => x.Id);
                    ViewProduct pro = new ViewProduct { Id = p, Cattegory = Cattegories.Where(x => x.Id == Cattegory).FirstOrDefault().Name, Name = Name, Price = float.Parse(Price.ToString()) };
                    return Json(pro);
                }
                catch (Exception ex)
                {
                    return Json("Error");
                }
            }
        }
        [HttpPost]
        public void DeleteProduct(int ID)
        {
            using (var context = new SqliteConnection("Data Source=myDB.db"))
            {
                context.Query($"delete from Products where Id={ID}");
            }
        }
        public JsonResult EditProduct(int ID, string Name, int? Cattegory, double? Price)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Price.ToString()) || string.IsNullOrEmpty(Cattegory.ToString()))
            {
                return Json("Error");
            }
            using (var context = new SqliteConnection("Data Source=myDB.db"))
            {
                context.Query($"update Products set Name='{Name}',Cattegory={Cattegory},Price={Price} where Id={ID}");
            }
            return Json("OK");
        }
        public ActionResult Cattegories(int id)
        {
            using (var context = new SqliteConnection("Data Source=myDB.db"))
            {
                var Cattegories = context.Query<Cattegories>($"select * from Cattegories").ToList();
                ViewBag.Cattegories = new SelectList(Cattegories.ToList(), "Id", "Name").ToList();
                var ProductList = context.Query<Product>($"select * from Products where Cattegory={id}");
                var Products = from item in ProductList
                               select new ViewProduct { Cattegory = Cattegories.Where(x => x.Id == item.Cattegory).FirstOrDefault().Name, Name = item.Name, Id = item.Id, Price = item.Price };
                return View(Products.ToList());
            }
        }
    }
}