﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Web.Mvc;
using GleamTech.Examples;
using GleamTech.ImageUltimate;
using GleamTech.ImageUltimate.AspNet;
using GleamTech.ImageUltimateExamples.Mvc.CS.Models;
using GleamTech.Util;

namespace GleamTech.ImageUltimateExamples.Mvc.CS.Controllers
{
    public partial class HomeController
    {
        private static readonly Expression<Action<ImageWebTask>>[] TaskExpressions = {
            task => task.ResizeWidth(300, ResizeMode.Max),
            task => task.ResizeHeight(200, ResizeMode.Max),
            task => task.Resize(300, 300, ResizeMode.Max),
            task => task.ResizeWidth(50, ResizeMode.Percentage),
            task => task.Resize(50, 60, ResizeMode.Percentage),
            task => task.Resize(300, 300, ResizeMode.Stretch),
            task => task.LiquidResize(75, 100, ResizeMode.Percentage),
            task => task.Crop(0, 0, 150, 150),
            task => task.TrimBorders(Color.Black, 10),
            task => task.Rotate(45, Color.Transparent),
            task => task.Rotate(-45, Color.Transparent),
            task => task.FlipHorizontal(),
            task => task.FlipVertical(),
            task => task.Brightness(20),
            task => task.Brightness(-20),
            task => task.Contrast(20),
            task => task.Contrast(-20),
            task => task.BrightnessContrast(20, 20),
            task => task.Enhance(),
            task => task.Blur(1),
            task => task.Sharpen(1),
            task => task.Format(ImageWebSafeFormat.Png),
            task => task.FileName("CustomNameForSEO")
        };

        public ActionResult Processing()
        {
            int selectedValue;
            int.TryParse(Request["taskSelector"], out selectedValue);

            var model = new ProcessingViewModel
            {
                ExampleFileSelector = new ExampleFileSelector
                {
                    Id = "exampleFileSelector",
                    InitialFile = "JPG Image.jpg",
                    FormWrapped = false
                },
                TaskSelectList = PopulateTaskSelector(selectedValue)
            };

            model.ImagePath = model.ExampleFileSelector.SelectedFile;

            var expression = TaskExpressions[selectedValue];
            var lambda = expression.Compile();

            model.TaskAction = task =>
            {
                task.ResizeWidth(400);
                lambda(task);
            };

            model.CodeString = string.Format(
                "@this.ImageTag(\"{0}\", {1})",
                model.ExampleFileSelector.SelectedFile.FileName,
                ExpressionStringBuilder.ToString(expression)
            );

            return View(model);
        }

        private List<SelectListItem> PopulateTaskSelector(int selectedValue)
        {
            var items = new List<SelectListItem>();

            for (var i = 0; i < TaskExpressions.Length; i++)
            {
                items.Add(
                    new SelectListItem { 
                        Text = ExpressionStringBuilder.ToString(TaskExpressions[i]),
                        Value = i.ToString(),
                        Selected = (i == selectedValue)
                    }
                );
            }

            return items;
        }
    }
}
