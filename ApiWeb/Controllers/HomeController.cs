using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ApiWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var xmlFile = "documentacion_swagger_apiweb.XML";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, "bin");
            xmlPath = Path.Combine(xmlPath, xmlFile);
            ViewBag.path = xmlPath;

            return View();
        }
    }
}
