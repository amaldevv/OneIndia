using System.Web;
using System.Web.Optimization;

namespace OneIndiaInfo
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

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include("~/Scripts/kendo.ui.core.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryrel").Include(
            "~/Scripts/jquery-migrate-1.0.0.min.js",
            "~/Scripts/jquery-ui-1.10.0.custom.min.js",
            "~/Scripts/jquery.ui.touch-punch.js",
            "~/Scripts/jquery.cookie.js",
            "~/Scripts/fullcalendar.min.js",
            "~/Scripts/jquery.dataTables.min.js",
            "~/Scripts/excanvas.js",
            "~/Scripts/jquery.flot.js",
            "~/Scripts/jquery.flot.pie.js",
            "~/Scripts/jquery.flot.stack.js",
            "~/Scripts/jquery.flot.resize.min.js",
            "~/Scripts/jquery.chosen.min.js",
            "~/Scripts/jquery.uniform.min.js",
            "~/Scripts/jquery.cleditor.min.js",
            "~/Scripts/jquery.noty.js",
            "~/Scripts/jquery.elfinder.min.js",
            "~/Scripts/jquery.raty.min.js",
            "~/Scripts/jquery.iphone.toggle.js",
            "~/Scripts/jquery.uploadify-3.1.min.js",
            "~/Scripts/jquery.gritter.min.js",
            "~/Scripts/jquery.imagesloaded.js",
            "~/Scripts/jquery.masonry.min.js",
            "~/Scripts/jquery.knob.modified.js",
            "~/Scripts/jquery.sparkline.min.js",
            "~/Scripts/counter.js",
            "~/Scripts/retina.js",
            "~/Scripts/custom.js"
         ));
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
            bundles.Add(new StyleBundle("~/Content/kendo").Include(
                      "~/Content/kendo.common.min.css",
                      "~/Content/kendo.default.min.css"));
        }
    }
}
