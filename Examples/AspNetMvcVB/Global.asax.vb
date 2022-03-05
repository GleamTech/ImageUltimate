Imports System.Web.Mvc
Imports System.Web.Routing
Imports System.IO
Imports GleamTech.AspNet
Imports GleamTech.ImageUltimate

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        RouteConfig.RegisterRoutes(RouteTable.Routes)

        Dim gleamTechConfig = Hosting.ResolvePhysicalPath("~/App_Data/GleamTech.config")
        If File.Exists(gleamTechConfig) Then
            GleamTechConfiguration.Current.Load(gleamTechConfig)
        End If

        Dim imageUltimateConfig = Hosting.ResolvePhysicalPath("~/App_Data/ImageUltimate.config")
        If File.Exists(imageUltimateConfig) Then
            ImageUltimateConfiguration.Current.Load(imageUltimateConfig)
        End If
    End Sub
End Class
