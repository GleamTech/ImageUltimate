using System;
using System.Collections;
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
                model.ImageData.Add("⤷ ColorModel", imageInfo.PixelFormatInfo.ColorModel);
                model.ImageData.Add("⤷ BitDepth", imageInfo.PixelFormatInfo.BitDepth);
                model.ImageData.Add("⤷ HasAlpha", imageInfo.PixelFormatInfo.HasAlpha);
                model.ImageData.Add("⤷ IsIndexed", imageInfo.PixelFormatInfo.IsIndexed);
                model.ImageData.Add("⤷ IsRgb", imageInfo.PixelFormatInfo.IsRgb);
                model.ImageData.Add("⤷ IsExtended", imageInfo.PixelFormatInfo.IsExtended);
                model.ImageData.Add("⤷ ChannelCount", imageInfo.PixelFormatInfo.ChannelCount);
                model.ImageData.Add("⤷ MaxChannelValue", imageInfo.PixelFormatInfo.MaxChannelValue);

                foreach (var entry in imageInfo.ExifDictionary)
                    model.ImageExifMetadata.Add(entry.Key.ToString(), Tuple.Create(GetStringValue(entry), entry.Description));

                if (model.ImageExifMetadata.Count == 0)
                    model.ImageExifMetadata.Add("", Tuple.Create("", ""));

                foreach (var entry in imageInfo.IptcDictionary)
                    model.ImageIptcMetadata.Add(entry.Key.ToString(), Tuple.Create(GetStringValue(entry), entry.Description));

                if (model.ImageIptcMetadata.Count == 0)
                    model.ImageIptcMetadata.Add("", Tuple.Create("", ""));
            }

            return View(model);
        }

        private static string GetStringValue<TKey>(MetadataEntry<TKey> entry)
        {
            if (entry.Value is string)
                return entry.ValueString;

            var valueType = entry.Value.GetType();
            if (valueType.IsArray)
                return string.Format("{0} array with length {1}", valueType.GetElementType(), ((ICollection)entry.Value).Count);

            if (entry.Values.Length > 1)
                return string.Format("{0} array with length {1}", entry.Values[0].GetType(), entry.Values.Length);

            return entry.ValueString;
        }
    }
}
