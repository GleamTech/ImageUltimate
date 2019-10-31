using System;
using System.Collections.Generic;
using GleamTech.Examples;

namespace GleamTech.ImageUltimateExamples.AspNetMvcCS.Models
{
    public class OverviewViewModel
    {
        public OverviewViewModel()
        {
            ImageData = new Dictionary<string, object>();
            ImageExifMetadata = new Dictionary<string, Tuple<string, string>>();
            ImageIptcMetadata = new Dictionary<string, Tuple<string, string>>();
        }

        public ExampleFileSelector ExampleFileSelector { get; set; }

        public Dictionary<string, object> ImageData { get; set; }

        public Dictionary<string, Tuple<string, string>> ImageExifMetadata { get; set; }

        public Dictionary<string, Tuple<string, string>> ImageIptcMetadata { get; set; }

        public string ImagePath { get; set; }
    }
}