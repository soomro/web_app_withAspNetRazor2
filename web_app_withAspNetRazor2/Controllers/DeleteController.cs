using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_app_withAspNetRazor2.Models;

namespace web_app_withAspNetRazor2.Controllers
{
    public class DeleteController : Controller
    {
        Northwnd context = new Northwnd();

        // GET: Delete
        public ActionResult Index()
        {
            return View();
        }

    }
}