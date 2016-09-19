using System;
using System.Drawing;
using System.Linq;
using System.Web.Mvc;
using GleamTech.ExamplesCore;
using GleamTech.ImageUltimate;
using GleamTech.ImageUltimate.Web;
using GleamTech.ImageUltimateExamples.Mvc.CS.Models;

namespace GleamTech.ImageUltimateExamples.Mvc.CS.Controllers
{
    public partial class HomeController
    {
        public ActionResult Processing()
        {
            var model = new ProcessingViewModel
            {
                ExampleFileSelector = new ExampleFileSelector
                {
                    ID = "exampleFileSelector",
                    InitialFile = "JPG Image.jpg",
                    FormWrapped = false
                },
                TaskSelectList = PopulateTaskSelector(Request["taskSelector"])
            };

            model.ImagePath = model.ExampleFileSelector.SelectedFile;
            model.TaskAction = GetTaskAction(Request["taskSelector"] ?? model.TaskSelectList.First().Text);

            return View(model);
        }

        private SelectList PopulateTaskSelector(string selectedValue)
        {
            return new SelectList(new[]
            {
                new SelectListItem {Text = "ResizeWidth(300)"},
                new SelectListItem {Text = "ResizeHeight(300)"},
                new SelectListItem {Text = "Resize(300, 300)"},
                new SelectListItem {Text = "Resize(300, 300, ResizeMode.Crop)"},
                new SelectListItem {Text = "Resize(300, 300, ResizeMode.Stretch)"},
                new SelectListItem {Text = "Crop(0, 0, 300, 300)"},
                new SelectListItem {Text = "CropBorders(Color.Black, 10)"},
                new SelectListItem {Text = "Rotate(45)"},
                new SelectListItem {Text = "Rotate(-45)"},
                new SelectListItem {Text = "Flip(FlipMode.Horizontal)"},
                new SelectListItem {Text = "Flip(FlipMode.Vertical)"},
                new SelectListItem {Text = "Brightness(20)"},
                new SelectListItem {Text = "Brightness(-20)"},
                new SelectListItem {Text = "BrightnessAuto()"},
                new SelectListItem {Text = "Contrast(20)"},
                new SelectListItem {Text = "Contrast(-20)"},
                new SelectListItem {Text = "ContrastAuto()"},
                new SelectListItem {Text = "BrightnessContrast(20, 20)"},
                new SelectListItem {Text = "Format(ImageWebSaveFormat.Png)"},
                new SelectListItem {Text = "FileName(\"CustomNameForSEO\")"}
            }, "Text", "Text", selectedValue);
        }

        private Action<ImageWebTask> GetTaskAction(string taskSelector)
        {
            switch (taskSelector)
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
