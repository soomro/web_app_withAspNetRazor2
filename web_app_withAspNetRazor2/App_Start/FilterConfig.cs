using System.Web;
using System.Web.Mvc;

namespace web_app_withAspNetRazor2
{
    public class FilterConfig
    {
        // error handling
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
