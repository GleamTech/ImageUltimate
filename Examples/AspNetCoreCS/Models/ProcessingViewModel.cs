using System;
using System.Collections.Generic;
using GleamTech.Examples;
using GleamTech.ImageUltimate.AspNet;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GleamTech.ImageUltimateExamples.AspNetCoreCS.Models
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
