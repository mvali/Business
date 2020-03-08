using System.Web;
using System.Web.Optimization;

namespace Main
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            */

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Assets/Js/jquery.js",
                "~/Assets/Js/jquery.prettyPhoto.js",
                "~/Assets/Js/jquery.isotope.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Assets/Js/bootstrap.min.js",
                "~/Assets/Js/main.js",
                "~/Assets/Js/wow.min.js",
                "~/Assets/Js/move-top.js",
                "~/Assets/Js/easing.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                                "~/Assets/Js/jquery.validate.js", //"~/Assets/Js/jquery.validate*",
                                "~/Assets/Js/jquery.unobtrusive-ajax.min.js"
                                ));

            bundles.Add(new StyleBundle("~/assets/bundles/css").Include(
                "~/Assets/Css/bootstrap.min.css",
                "~/Assets/Css/animate.min.css",
                "~/Assets/Css/prettyPhoto.css",
                "~/Assets/Css/main.css",
                "~/Assets/Css/responsive.css",
                "~/Assets/Css/font-awesome.min.css"
                      ));

        }
    }
}
