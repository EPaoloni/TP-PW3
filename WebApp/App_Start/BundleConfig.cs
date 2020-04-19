using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Hosting;

namespace WebApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            //usa Include() para agregar el archivo css
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                                                    "~/Content/lib/materialize/css/materialize.css",
                                                    "~/Content/site.css"
                                                ));

            //usa Include() para agregar el script js
            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                                        "~/Scripts/lib/angulajs/angular.js",
                                         "~/Scripts/app/app.module.js"
                                    ));

            //usa Include() para agregar el script js en el footer
            bundles.Add(new ScriptBundle("~/bundles/footer").Include(
                                        "~/Scripts/lib/jquery/jquery-2.1.1.js",
                                        "~/Scripts/lib/materialize/materialize.js"
                                    ));
        }
    }
}