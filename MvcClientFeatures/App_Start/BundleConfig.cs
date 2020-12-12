using System.Web.Optimization;

namespace MvcClientFeatures
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/*.css"));

            bundles.Add(new ScriptBundle("~/bundles/mvcclientfeaturesscripts").Include(
                       "~/Scripts/jquery-{version}.js", "~/Scripts/jquery.validate.js", "~/Scripts/jquery.validate.unobtrusive.js", "~/Scripts/jquery.unobtrusive-ajax.js"));

        }
    }
}