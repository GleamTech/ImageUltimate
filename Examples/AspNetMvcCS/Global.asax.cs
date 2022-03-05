using System.IO;
using System.Web.Mvc;
using System.Web.Routing;
using GleamTech.AspNet;
using GleamTech.ImageUltimate;

namespace GleamTech.ImageUltimateExamples.AspNetMvcCS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var gleamTechConfig = Hosting.ResolvePhysicalPath("~/App_Data/GleamTech.config");
            if (File.Exists(gleamTechConfig))
                GleamTechConfiguration.Current.Load(gleamTechConfig);
            
            var imageUltimateConfig = Hosting.ResolvePhysicalPath("~/App_Data/ImageUltimate.config");
            if (File.Exists(imageUltimateConfig))
                ImageUltimateConfiguration.Current.Load(imageUltimateConfig);
        }
    }
}