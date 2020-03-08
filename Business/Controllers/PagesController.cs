using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Business.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pricing() { return View(); }
        public ActionResult E404() { return View(); }
        public ActionResult Shortcodes() { return View(); }
        public ActionResult Blog() { return View(); }
        public ActionResult Blog2() { return View(); }
    }
}