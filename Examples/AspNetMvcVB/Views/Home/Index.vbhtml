@Imports GleamTech.AspNet.Mvc
@Imports GleamTech.Examples
@Imports GleamTech.ImageUltimate
@Code
    Dim exampleExplorer = New ExampleExplorer() With {
        .DisplayMode = GleamTech.AspNet.UI.DisplayMode.Viewport,
        .NavigationTitle = "ImageUltimate Examples",
        .VersionTitle = "v" & ImageUltimateConfiguration.AssemblyInfo.FileVersion.ToString,
        .Examples = New ExampleBase() {
            New Example() With {
                .Title = "Overview",
                .Url = "Home/Overview",
                .SourceFiles = New String() {"Views/Home/Overview.vbhtml", "Controllers/HomeController.Overview.vb"},
                .DescriptionFile = "Descriptions/Overview.html"
            },
            New Example() With {
                .Title = "Image Processing",
                .Url = "Home/Processing",
                .SourceFiles = New String() {"Views/Home/Processing.vbhtml", "Controllers/HomeController.Processing.vb"},
                .DescriptionFile = "Descriptions/Processing.html"
            }
        },
        .ExampleProjectName = "ASP.NET MVC (VB)",
        .ExampleProjects = ExamplesConfiguration.LoadExampleProjects(Server.MapPath("~/App_Data/ExampleProjects.json"))
    }
End Code
<!DOCTYPE html>

<html>
<head>
    <title>ImageUltimate Examples - ASP.NET MVC (VB)</title>

    @Me.RenderHead(exampleExplorer)
</head>
<body>
    @Me.RenderBody(exampleExplorer)
</body>
</html>
