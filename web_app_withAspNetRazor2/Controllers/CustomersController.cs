using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_app_withAspNetRazor2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        // Add customer
        public ActionResult Add()
        {
            return View();
        }
        
        // Edit customer
        public ActionResult Edit(int Id)
        {
            return View();
        }

        // Delete customer
        public string Delete()
        {
            return "Delete";
        }
    }
}