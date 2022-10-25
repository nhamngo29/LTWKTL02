using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KT2_2001207130_26.Models;
namespace KT2_2001207130_26.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        FlowerDBEntities DB=new FlowerDBEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNew(Product s)
        {
            DB.Products.Add(s);
            DB.SaveChanges();
            return RedirectToAction("Index", "Products");
        }
    }
}