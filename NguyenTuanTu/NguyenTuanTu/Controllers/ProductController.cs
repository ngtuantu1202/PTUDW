using NguyenTuanTu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenTuanTu.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> GetSampleProductList()
        {
            return new List<Product>
    {
        new Product { Id = 1, Name = "Bàn phím ReZero", ImageUrl = "sp1.jpg", Price = 500 },
        new Product { Id = 2, Name = "Bàn phím đen trắng", ImageUrl = "sp2.jpg", Price = 450 },
        new Product { Id = 3, Name = "Bàn phím Hutao", ImageUrl = "sp3.jpg", Price = 1000 }
    };
        }


        public ActionResult Index()
        {
            List<Product> productList = GetSampleProductList();
            return View(productList);
        }

        public ActionResult Details(int id)
        {
            Product product = GetSampleProductList().FirstOrDefault(p => p.Id == id);
            return View(product);
        }
    }

}