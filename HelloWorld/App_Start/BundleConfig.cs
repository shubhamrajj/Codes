using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace HelloWorld.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css/bootstrap")
                .Include("~/Content/Site.css","~/Content/bootstrap.min.css",
                "~/Content/bootstrap-theme.min.css"));

            bundles.Add(new ScriptBundle("~/scripts/bootstrap")
                .Include("~/Scripts/bootstrap.min.js","~/Scripts/jquery-1.9.0.min.js",
                "~/Scripts/jquery-1.9.0.min.map"));
        }
    }
}