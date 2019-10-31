using System;
using System.Collections.Generic;
using System.Web.Mvc;
using GleamTech.Examples;
using GleamTech.ImageUltimate.AspNet;

namespace GleamTech.ImageUltimateExamples.AspNetMvcCS.Models
{
    public class ProcessingViewModel
    {
        public ExampleFileSelector ExampleFileSelector { get; set; }

        public List<SelectListItem> TaskSelectList { get; set; }

        public string ImagePath { get; set; }

        public Action<ImageWebTask> TaskAction { get; set; }

        public string CodeString { get; set; }
    }
}