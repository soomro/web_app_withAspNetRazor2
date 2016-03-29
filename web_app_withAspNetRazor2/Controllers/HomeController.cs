using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_app_withAspNetRazor2.Controllers
{
    // The name of the controller is Home but it's created as HomeController.
    // it's used in RouteConfig.cs as Home
    public class HomeController : Controller
    {
        // The name of Action is FunctionName
        // /home/index/5    for. e.g. action "index" , id '5'

        // "ActionResult" is the view type which will return to view.
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}