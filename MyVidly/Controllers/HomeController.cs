using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MyVidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {    [OutputCache(Duration = 10,Location = OutputCacheLocation.Server,VaryByParam = "Genre")]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 100, Location = OutputCacheLocation.Client)]

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    
        [OutputCache(Duration = 100,Location = OutputCacheLocation.Client)]

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}