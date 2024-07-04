using System.Web;
using System.Web.Optimization;

namespace NvhK22cntt3Lession11_2210900031
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            

            {

                bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                            "~/Scripts/jquery-1.10.2.js"));

                bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                            "~/Scripts/jquery.validate.js"));

                bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-2.6.2.js"));
            }
        }
    }
}
