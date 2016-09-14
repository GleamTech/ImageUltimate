using System;
using System.Web.UI;
using GleamTech.ExamplesCore;

namespace GleamTech.ImageUltimateExamples.WebForms.CS
{
    public partial class DefaultPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            exampleExplorer.Examples = new ExampleBase[]
            {
                new Example
                {
                    Title = "Overview",
                    Url = "Overview.aspx",
                    SourceFiles = new[] { "Overview.aspx", "Overview.aspx.cs"},
                    DescriptionFile = "Descriptions/Overview.html"
                }
            };

            exampleExplorer.ExampleProjectName = "ASP.NET Web Forms (C#)";
            exampleExplorer.ExampleProjects = ExamplesCoreConfiguration.LoadExampleProjects(Server.MapPath("~/App_Data/ExampleProjects.json"));
        }
    }
}
