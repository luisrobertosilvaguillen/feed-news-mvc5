using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/popper.min.js",
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/base").Include(
                   "~/Scripts/plugins.js",
                   "~/Scripts/active.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/bootstrap.min.css",
                       "~/Content/classy-nav.css",
                       "~/Content/owl.carousel.min.css",
                       "~/Content/animate.css",
                       "~/Content/magnific-popup.css",
                       "~/Content/font-awesome.min.css",
                       "~/Content/nice-select.css",
                      "~/Content/site.css"));
        }
    }
}
