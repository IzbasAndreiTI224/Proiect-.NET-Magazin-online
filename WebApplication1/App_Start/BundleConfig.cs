using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                      "~/Content/styles.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/script/js").Include(
          "~/Scripts/script.js"));


            bundles.Add(new StyleBundle("~/bundles/style1/css").Include(
                      "~/Content/styles1.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/style2/css").Include(
                      "~/Content/styles2.css", new CssRewriteUrlTransform()));





            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                 "~/Content/bootstrap.css",
                  "~/Content/bootstrap-theme.css"));


            bundles.Add(new Bundle("~/bundles/bootstrap/js").Include(
                  "~/Scripts/bootstrap.js"));



        }
    }
}