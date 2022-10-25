using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KT2_2001207130_26.Models;
namespace KT2_2001207130_26.Controllers
{
    public class ProductsController : Controller
    {

        // GET: Products
        FlowerDBEntities DB= new FlowerDBEntities();
        [Route("Products/Index/{Sort:int?}")]
        public ActionResult Index(int? Sort,string Srearch="")
        {
            List<Product> products = DB.Products.Where(t => t.Category.Name.Contains(Srearch)).ToList();
            if (Sort==1)
            {
                products = products.OrderBy(t => t.Price).ToList();
            }
            else
                products = products.OrderByDescending(t => t.Price).ToList();
            List<Category> categories= DB.Categories.ToList();
            ViewBag.categories = categories;
            return View(products);
        }
        public ActionResult Detail(int Id)
        {
            Product product = DB.Products.Find(Id);
            return View(product);
        }
        
    }
}