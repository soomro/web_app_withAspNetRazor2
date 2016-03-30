using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_app_withAspNetRazor2.Models;

namespace web_app_withAspNetRazor2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> customers;

            using(Northwnd a = new Northwnd())
            {
                customers = a.Customers.OrderBy(c => c.CompanyName).ToList();
            }

            return View(customers);
        }

        // Add customer
        public ActionResult Add()
        {
            return View();
        }
        
        // Edit customer
        // with ? it can accept null value  
        public ActionResult Edit(int? Id)
        {
            if (Id.HasValue)
            {
                // fetch from database . Hämta från databas
            }
            return View();
        }

        // Delete customer
        public string Delete()
        {
            return "Delete";
        }
    }
}