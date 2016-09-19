using System;
using System.Drawing;
using System.Web.UI.WebControls;
using GleamTech.ImageUltimate;
using GleamTech.ImageUltimate.Web;

namespace GleamTech.ImageUltimateExamples.WebForms.CS
{
    public partial class ProcessingPage : System.Web.UI.Page
    {
        protected string ImagePath;
        protected Action<ImageWebTask> TaskAction;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ImagePath = exampleFileSelector.SelectedFile;

            if (!IsPostBack)
                PopulateTaskSelector();

            TaskAction = GetTaskAction();
        }

        private void PopulateTaskSelector()
        {
            TaskSelector.Items.AddRange(new[]
            {
                new ListItem("ResizeWidth(300)"),
                new ListItem("ResizeHeight(300)"),
                new ListItem("Resize(300, 300)"),
                new ListItem("Resize(300, 300, ResizeMode.Crop)"),
                new ListItem("Resize(300, 300, ResizeMode.Stretch)"),
                new ListItem("Crop(0, 0, 300, 300)"),
                new ListItem("CropBorders(Color.Black, 10)"),
                new ListItem("Rotate(45)"),
                new ListItem("Rotate(-45)"),
                new ListItem("Flip(FlipMode.Horizontal)"),
                new ListItem("Flip(FlipMode.Vertical)"),
                new ListItem("Brightness(20)"),
                new ListItem("Brightness(-20)"),
                new ListItem("BrightnessAuto()"),
                new ListItem("Contrast(20)"),
                new ListItem("Contrast(-20)"),
                new ListItem("ContrastAuto()"),
                new ListItem("BrightnessContrast(20, 20)"),
                new ListItem("Format(ImageWebSaveFormat.Png)"),
                new ListItem("FileName(\"CustomNameForSEO\")")
            });
        }

        private Action<ImageWebTask> GetTaskAction()
        {
            switch (TaskSelector.SelectedValue)
            {
                case "ResizeWidth(300)":
                    return task => task.ResizeWidth(300);
                case "ResizeHeight(300)":
                    return task => task.ResizeHeight(300);
                case "Resize(300, 300)":
                    return task => task.Resize(300, 300);
                case "Resize(300, 300, ResizeMode.Crop)":
                    return task => task.Resize(300, 300, ResizeMode.Crop);
                case "Resize(300, 300, ResizeMode.Stretch)":
                    return task => task.Resize(300, 300, ResizeMode.Stretch);
                case "Crop(0, 0, 300, 300)":
                    return task => task.Crop(0, 0, 300, 300);
                case "CropBorders(Color.Black, 10)":
                    return task => task.ResizeWidth(300).CropBorders(Color.Black, 10);
                case "Rotate(45)":
                    return task => task.ResizeWidth(300).Rotate(45);
                case "Rotate(-45)":
                    return task => task.ResizeWidth(300).Rotate(-45);
                case "Flip(FlipMode.Horizontal)":
                    return task => task.ResizeWidth(300).Flip(FlipMode.Horizontal);
                case "Flip(FlipMode.Vertical)":
                    return task => task.ResizeWidth(300).Flip(FlipMode.Vertical);
                case "Brightness(20)":
                    return task => task.ResizeWidth(300).Brightness(20);
                case "Brightness(-20)":
                    return task => task.ResizeWidth(300).Brightness(-20);
                case "BrightnessAuto()":
                    return task => task.ResizeWidth(300).BrightnessAuto();
                case "Contrast(20)":
                    return task => task.ResizeWidth(300).Contrast(20);
                case "Contrast(-20)":
                    return task => task.ResizeWidth(300).Contrast(-20);
                case "ContrastAuto()":
                    return task => task.ResizeWidth(300).ContrastAuto();
                case "BrightnessContrast(20, 20)":
                    return task => task.ResizeWidth(300).BrightnessContrast(20, 20);
                case "Format(ImageWebSaveFormat.Png)":
                    return task => task.ResizeWidth(300).Format(ImageWebSaveFormat.Png);
                case "FileName(\"CustomNameForSEO\")":
                    return task => task.ResizeWidth(300).FileName("CustomNameForSEO");
                default:
                    return null;
            }
        }
    }
}