using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductManagementSystem.Models.Repository;

namespace ProductManagementSystem.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            CustomerRepository customerRepository=new CustomerRepository();
            var allCustomers= customerRepository.GetAllCustomers();
            return View(allCustomers);
        }
    }
}