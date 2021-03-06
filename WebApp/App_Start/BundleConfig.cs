﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            //usa Include() para agregar el archivo css
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                                                    "~/Content/lib/materialize/materialize.css",
                                                    "~/Content/site.css",
                                                    "~/Content/src/*.css"
                                                ));

            //usa Include() para agregar el script js
            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                                        "~/Scripts/lib/materialize/materialize.js",
                                        "~/Scripts/lib/jquery/jquery.js",
                                        "~/Scripts/lib/jquery/jquery.validate.js",
                                        "~/Scripts/lib/jquery/jquery.validate.unobtrusive.js",
                                        "~/Scripts/lib/popper/popper.js",
                                        "~/Scripts/lib/popper/popper.min.js",
                                        "~/Scripts/lib/toast/toast.js",
                                        "~/Scripts/src/*.js"
                                    ));

            //usa Include() para agregar el script js en el footer
            bundles.Add(new ScriptBundle("~/bundles/footer").Include(
                                    ));
        }
    }
}