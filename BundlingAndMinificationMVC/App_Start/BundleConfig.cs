using System.Web.Optimization;

namespace BundlingAndMinificationMVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Sample/javascript")
                .Include("~/Scripts/bootstrap.bundle.js",
                "~/Scripts/bootstrap.bundle.js.map",
                "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Sample/css")
                    .Include("~/Content/bootstrap-grid.css")
                    .Include("~/Content/bootstrap.css")
                    .Include("~/Content/bootstrap.rtl.css")
                );

            BundleTable.EnableOptimizations = true;
        }
    }
}