using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductManagementSystem.Models.PMSModel;
using ProductManagementSystem.Models.Repository;

namespace ProductManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductRepository productRepository=new ProductRepository();
           var products = productRepository.GetAllProducts();
            //var products = productRepository.GetAllProductsAdo();           
            //TempData["products"] = products;
            return View(products);
        }

        public ActionResult Create()
        {
            //ViewBag.message = "I am from viewbag";
            //ViewData["msg"] = "I am from  viewdata";
            //ViewData["AllProducts"] = TempData["products"];
            return View();
        }
       
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepository productRepository=new ProductRepository();
                //productRepository.AddProduct(product);  
                 productRepository.InsertIntoProductUsingAdo(product);
                //productRepository.InsertProductUsingSp(product);
            }
            //_db.Entry(productToUpdate).CurrentValues.SetValues(product);
            return RedirectToAction("Index");
        }
    }
}