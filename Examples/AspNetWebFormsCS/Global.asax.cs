using System;
using System.IO;
using System.Web;
using GleamTech.AspNet;
using GleamTech.ImageUltimate;

namespace GleamTech.ImageUltimateExamples.AspNetWebFormsCS
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var gleamTechConfig = Hosting.ResolvePhysicalPath("~/App_Data/GleamTech.config");
            if (File.Exists(gleamTechConfig))
                GleamTechConfiguration.Current.Load(gleamTechConfig);

            var imageUltimateConfig = Hosting.ResolvePhysicalPath("~/App_Data/ImageUltimate.config");
            if (File.Exists(imageUltimateConfig))
                ImageUltimateConfiguration.Current.Load(imageUltimateConfig);
        }
    }
}