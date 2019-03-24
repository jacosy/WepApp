using System.Web.Optimization;

namespace WepAppMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatable").Include(
                   "~/Scripts/DataTable/DataTable/jquery.dataTables.js",
                   "~/Scripts/DataTable/DataTable/DataTables.bootstrap.js",
                   "~/Scripts/DataTable/Buttons/js/dataTables.buttons.js",
                   "~/Scripts/DataTable/Buttons/js/buttons.bootstrap.js",
                   "~/Scripts/DataTable/Buttons/js/buttons.html5.js",
                   "~/Scripts/DataTable/Buttons/js/buttons.print.js",
                   "~/Scripts/DataTable/Buttons/js/buttons.flash.js",
                   "~/Scripts/DataTable/Responsive/dataTables.responsive.js",
                   "~/Scripts/DataTable/Responsive/responsive.bootstrap.js",
                   "~/Scripts/DataTable/Select/dataTables.select.js",
                   "~/Scripts/DataTable/Select/select.bootstrap.js",
                   "~/Scripts/DataTable/Editor/dataTables.editor.js",
                   "~/Scripts/DataTable/Editor/editor.bootstrap.js"
               ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/datatable").Include(
                   "~/Content/DataTable/DataTable/css/dataTables.bootstrap.css",
                   "~/Content/DataTable/Buttons/buttons.bootstrap.css",
                   "~/Content/DataTable/Responsive/responsive.bootstrap.css",
                   "~/Content/DataTable/Select/select.bootstrap.css",
                   "~/Content/DataTable/Editor/editor.bootstrap.css"
               ));
        }
    }
}
