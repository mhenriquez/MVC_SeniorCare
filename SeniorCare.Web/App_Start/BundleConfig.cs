using System.Web;
using System.Web.Optimization;

namespace SeniorCare.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/scripts/google-tag-manager.js",
                      "~/scripts/jquery-{version}.js",
                      "~/scripts/bootstrap.js",
                      "~/scripts/respond.js"));

            bundles.Add(new StyleBundle("~/content/css").Include(
                      "~/content/bootstrap.css",
                      "~/content/font-awesome.css",
                      "~/content/site.css"));
        }
    }
}
