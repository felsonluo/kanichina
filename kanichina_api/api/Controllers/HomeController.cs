using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace api.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            ViewBag.Title = "Home Page";

            return Json("");
        }

        public JsonResult GetProduct()
        {
            return Json(new Product() { id = "1" }, JsonRequestBehavior.AllowGet);
        }
    }
}
