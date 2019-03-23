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
                   "~/Scripts/DataTable/DataTable/jquery.dataTables.min.js",
                   "~/Scripts/DataTable/DataTables.bootstrap.min.js",
                   "~/Scripts/DataTable/Buttons/js/dataTables.buttons.min.js",
                   "~/Scripts/DataTable/Buttons/js/buttons.bootstrap.min.js",
                   "~/Scripts/DataTable/Responsive/dataTables.responsive.min.js",
                   "~/Scripts/DataTable/Responsive/responsive.bootstrap.min.js",
                   "~/Scripts/DataTable/Select/dataTables.select.min.js",
                   "~/Scripts/DataTable/Select/select.bootstrap.min.js",
                   "~/Scripts/DataTable/Editor/dataTables.editor.min.js",
                   "~/Scripts/DataTable/Eeditor/editor.bootstrap.min.js"
               ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/datatable").Include(
                   "~/Content/DataTable/DataTable/css/jquery.dataTables.min.css",
                   "~/Content/DataTable/DataTable/css/dataTables.bootstrap.min.css",
                   "~/Content/DataTable/Buttons/buttons.dataTables.min.css",
                   "~/Content/DataTable/Buttons/buttons.bootstrap.min.css",
                   "~/Content/DataTable/Responsive/responsive.dataTables.min.css",
                   "~/Content/DataTable/Responsive/responsive.bootstrap.min.css",
                   "~/Content/DataTable/Select/select.dataTables.min.css",
                   "~/Content/DataTable/Select/select.bootstrap.min.css",
                   "~/Content/DataTable/Editor/editor.dataTables.min.css",
                   "~/Content/DataTable/Eeditor/editor.bootstrap.min.css"
               ));
        }
    }
}
