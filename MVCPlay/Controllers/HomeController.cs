using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPlay.Controllers
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

        public ActionResult Test()
        {
            ViewBag.Message = "Your test page.";
            ViewBag.Answer = "Waiting for input";
            return View();
        }
        public ActionResult SecondTest()
        {
            return View();
        }
        
        public ActionResult GetData()
        {
            return Json(new { foo = "bar", baz = "Blech" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Test(int n1, int n2)
        {
            ViewBag.Answer = n1 + n2;
            return View();
        }



        public JsonResult Data()
        {
            var users = new
            {
                id = 1,
                name = 23
            };
            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}