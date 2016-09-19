using System;
using System.Web.Mvc;
using GleamTech.ExamplesCore;
using GleamTech.ImageUltimate.Web;

namespace GleamTech.ImageUltimateExamples.Mvc.CS.Models
{
    public class ProcessingViewModel
    {
        public ExampleFileSelector ExampleFileSelector { get; set; }

        public SelectList TaskSelectList { get; set; }

        public string ImagePath { get; set; }

        public Action<ImageWebTask> TaskAction { get; set; }
    }
}