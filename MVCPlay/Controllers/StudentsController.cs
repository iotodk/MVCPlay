using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPlay.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Data()
        {
            var data = new
            {
                id = 1,
                name = "Ion",
                age = 100
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Test()
        {
            ViewBag.Answer = "Input the data and press Enter";
            return View();
        }

        [HttpPost]
        public ActionResult Test(int x, int y)
        {
            ViewBag.Answer = x + y;
            return View();
        }
    }
}