using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Main.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Services()
        {
            return View("Services2");
        }

    }
}
/*
    <link href="/Assets1/Css/bootstrap.min.css" rel="stylesheet">
    <link href="/Assets1/Css/font-awesome.min.css" rel="stylesheet">
    <link href="/Assets1/Css/animate.min.css" rel="stylesheet">
    <link href="/Assets1/Css/prettyPhoto.css" rel="stylesheet">
    <link href="/Assets1/Css/main.css" rel="stylesheet">
    <link href="/Assets1/Css/responsive.css" rel="stylesheet">

    <script src="/Assets1/Js/jquery.js"></script>
    <script src="/Assets1/Js/bootstrap.min.js"></script>
    <script src="/Assets1/Js/jquery.prettyPhoto.js"></script>
    <script src="/Assets1/Js/jquery.isotope.min.js"></script>
    <script src="/Assets1/Js/main.js"></script>
    <script src="/Assets1/Js/wow.min.js"></script>
    <script src="~/Assets1/Js/jquery.unobtrusive-ajax.min.js"></script>

*/
