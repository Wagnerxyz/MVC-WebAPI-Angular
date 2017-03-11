using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcformsauthentication.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult xsstest()
        {
            ViewBag.UserName1 = "Jon\x3cscript\x3e%20alert(\x27pwnd\x27)%20\x3c/script\x3e";

            return View();
        }
        public ActionResult GetWebApi()
        {
            //ViewBag.UserName1 = "Jon\x3cscript\x3e%20alert(\x27pwnd\x27)%20\x3c/script\x3e";

            return View();
        }
        public ActionResult AngularTest()
        {

            return View();
        }
    }
}