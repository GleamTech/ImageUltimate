using System;
using System.Collections.Generic;
using System.Web.UI;
using GleamTech.ImageUltimate;

namespace GleamTech.ImageUltimateExamples.WebForms.CS
{
    public partial class OverviewPage : Page
    {
        protected string ImagePath;
        protected Dictionary<string, object> ImageData = new Dictionary<string, object>();
        protected Dictionary<string, Tuple<string, string>> ImageExifMetadata = new Dictionary<string, Tuple<string, string>>();
        protected Dictionary<string, Tuple<string, string>> ImageIptcMetadata = new Dictionary<string, Tuple<string, string>>();

        protected void Page_Load(object sender, EventArgs e)
        {
            ImagePath = exampleFileSelector.SelectedFile;

            using (var imageInfo = new ImageInfo(ImagePath))
            {
                ImageData.Add("Format", imageInfo.Format);
                ImageData.Add("Width", imageInfo.Width);
                ImageData.Add("Height", imageInfo.Height);
                ImageData.Add("DpiX", imageInfo.DpiX);
                ImageData.Add("DpiY", imageInfo.DpiY);
                ImageData.Add("PixelFormat", imageInfo.PixelFormatInfo.Description);
                ImageData.Add("&#10551; ColorModel", imageInfo.PixelFormatInfo.ColorModel);
                ImageData.Add("&#10551; BitDepth", imageInfo.PixelFormatInfo.BitDepth);
                ImageData.Add("&#10551; HasAlpha", imageInfo.PixelFormatInfo.HasAlpha);
                ImageData.Add("&#10551; IsIndexed", imageInfo.PixelFormatInfo.IsIndexed);
                ImageData.Add("&#10551; IsRgb", imageInfo.PixelFormatInfo.IsRgb);
                ImageData.Add("&#10551; IsExtended", imageInfo.PixelFormatInfo.IsExtended);
                ImageData.Add("&#10551; ChannelCount", imageInfo.PixelFormatInfo.ChannelCount);
                ImageData.Add("&#10551; MaxChannelValue", imageInfo.PixelFormatInfo.MaxChannelValue);

                foreach (var entry in imageInfo.ExifDictionary)
                    ImageExifMetadata.Add(entry.Key.ToString(), Tuple.Create(entry.ValueString, entry.Description));

                if (ImageExifMetadata.Count == 0)
                    ImageExifMetadata.Add("", Tuple.Create("", ""));

                foreach (var entry in imageInfo.IptcDictionary)
                    ImageIptcMetadata.Add(entry.Key.ToString(), Tuple.Create(entry.ValueString, entry.Description));

                if (ImageIptcMetadata.Count == 0)
                    ImageIptcMetadata.Add("", Tuple.Create("", ""));
            }
        }
    }
}