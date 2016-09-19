@Imports GleamTech.ExamplesCore
@Imports GleamTech.Web.Mvc
@Code
    Dim exampleExplorer = New ExampleExplorer() With {
        .FullViewport = True,
        .NavigationTitle = "ImageUltimate Examples",
        .Examples = New ExampleBase() {
            New Example() With {
                .Title = "Overview",
                .Url = "home/Overview",
                .SourceFiles = New String() {"Views/Home/Overview.vbhtml", "Controllers/HomeController.Overview.vb"},
                .DescriptionFile = "Descriptions/Overview.html"
            },
            New Example() With {
                .Title = "Image Processing",
                .Url = "home/Processing",
                .SourceFiles = New String() {"Views/Home/Processing.vbhtml", "Controllers/HomeController.Processing.vb"},
                .DescriptionFile = "Descriptions/Processing.html"
            }
        },
        .ExampleProjectName = "ASP.NET MVC (VB)",
        .ExampleProjects = ExamplesCoreConfiguration.LoadExampleProjects(Server.MapPath("~/App_Data/ExampleProjects.json"))
    }
End Code
<!DOCTYPE html>

<html>
<head>
    <title>ImageUltimate Examples - ASP.NET MVC (VB)</title>

    @Html.RenderCss(exampleExplorer)
    @Html.RenderJs(exampleExplorer)

</head>
<body>
    @Html.RenderControl(exampleExplorer)
</body>
</html>
