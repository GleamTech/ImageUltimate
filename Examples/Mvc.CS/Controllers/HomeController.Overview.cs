using System;
using System.Web.Mvc;
using GleamTech.Examples;
using GleamTech.ImageUltimate;
using GleamTech.ImageUltimateExamples.Mvc.CS.Models;

namespace GleamTech.ImageUltimateExamples.Mvc.CS.Controllers
{
    public partial class HomeController
    {
        public ActionResult Overview()
        {
            var model = new OverviewViewModel
            {
                ExampleFileSelector = new ExampleFileSelector
                {
                    Id = "exampleFileSelector",
                    InitialFile = "JPG Image.jpg"
                }
            };

            model.ImagePath = model.ExampleFileSelector.SelectedFile;

            using (var imageInfo = new ImageInfo(model.ImagePath))
            {
                model.ImageData.Add("Format", imageInfo.Format);
                model.ImageData.Add("Width", imageInfo.Width);
                model.ImageData.Add("Height", imageInfo.Height);
                model.ImageData.Add("DpiX", imageInfo.DpiX);
                model.ImageData.Add("DpiY", imageInfo.DpiY);
                model.ImageData.Add("ColorSpace", imageInfo.ColorSpace);
                model.ImageData.Add("ColorType", imageInfo.ColorType);
                model.ImageData.Add("BitDepth", imageInfo.BitDepth);
                model.ImageData.Add("HasAlpha", imageInfo.HasAlpha);
                model.ImageData.Add("ChannelCount", imageInfo.ChannelCount);

                foreach (var entry in imageInfo.ExifDictionary)
                    model.ImageExifMetadata.Add(entry.Tag.ToString(), Tuple.Create(entry.Value, entry.Description));

                if (model.ImageExifMetadata.Count == 0)
                    model.ImageExifMetadata.Add("", Tuple.Create("", ""));

                foreach (var entry in imageInfo.IptcDictionary)
                    model.ImageIptcMetadata.Add(entry.Tag.ToString(), Tuple.Create(entry.Value, entry.Description));

                if (model.ImageIptcMetadata.Count == 0)
                    model.ImageIptcMetadata.Add("", Tuple.Create("", ""));
            }

            return View(model);
        }
    }
}
