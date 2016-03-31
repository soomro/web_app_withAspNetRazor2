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
        Northwnd context = new Northwnd();

        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> customers = context.Customers.OrderBy(c => c.ContactName).ToList();

            return View(customers);
        }

        // Add customer
        public ActionResult Add()
        {
            //TBD
            return View();
        }
        



        // Delete customer
        public string Delete()
        {
            //TBD
            return "Delete";
        }

        //
        //want: when i click item, it fetches details for customer and show on detail page.
        //
        public ActionResult Detail(string Id)
        {
            Customer customer = context.Customers.FirstOrDefault(c => c.CustomerID == Id);
            if(customer == null)
            {
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        //// Edit customer
        //// with ? it can accept null value  
        //public ActionResult Edit(int? Id)
        public ActionResult Edit(string Id)
        {
            //TBD
            return View();
        }

    }
}