using System;
using System.Web.Mvc;
using GleamTech.ExamplesCore;
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
                    ID = "exampleFileSelector",
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
                model.ImageData.Add("PixelFormat", imageInfo.PixelFormatInfo.Description);
                model.ImageData.Add("&#10551; ColorModel", imageInfo.PixelFormatInfo.ColorModel);
                model.ImageData.Add("&#10551; BitDepth", imageInfo.PixelFormatInfo.BitDepth);
                model.ImageData.Add("&#10551; HasAlpha", imageInfo.PixelFormatInfo.HasAlpha);
                model.ImageData.Add("&#10551; IsIndexed", imageInfo.PixelFormatInfo.IsIndexed);
                model.ImageData.Add("&#10551; IsRgb", imageInfo.PixelFormatInfo.IsRgb);
                model.ImageData.Add("&#10551; IsExtended", imageInfo.PixelFormatInfo.IsExtended);
                model.ImageData.Add("&#10551; ChannelCount", imageInfo.PixelFormatInfo.ChannelCount);
                model.ImageData.Add("&#10551; MaxChannelValue", imageInfo.PixelFormatInfo.MaxChannelValue);

                foreach (var entry in imageInfo.ExifDictionary)
                    model.ImageExifMetadata.Add(entry.Key.ToString(), Tuple.Create(entry.ValueString, entry.Description));

                if (model.ImageExifMetadata.Count == 0)
                    model.ImageExifMetadata.Add("", Tuple.Create("", ""));

                foreach (var entry in imageInfo.IptcDictionary)
                    model.ImageIptcMetadata.Add(entry.Key.ToString(), Tuple.Create(entry.ValueString, entry.Description));

                if (model.ImageIptcMetadata.Count == 0)
                    model.ImageIptcMetadata.Add("", Tuple.Create("", ""));
            }

            return View(model);
        }
    }
}
