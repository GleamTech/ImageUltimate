using System;
using System.Collections;
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
                ImageData.Add("⤷ ColorModel", imageInfo.PixelFormatInfo.ColorModel);
                ImageData.Add("⤷ BitDepth", imageInfo.PixelFormatInfo.BitDepth);
                ImageData.Add("⤷ HasAlpha", imageInfo.PixelFormatInfo.HasAlpha);
                ImageData.Add("⤷ IsIndexed", imageInfo.PixelFormatInfo.IsIndexed);
                ImageData.Add("⤷ IsRgb", imageInfo.PixelFormatInfo.IsRgb);
                ImageData.Add("⤷ IsExtended", imageInfo.PixelFormatInfo.IsExtended);
                ImageData.Add("⤷ ChannelCount", imageInfo.PixelFormatInfo.ChannelCount);
                ImageData.Add("⤷ MaxChannelValue", imageInfo.PixelFormatInfo.MaxChannelValue);

                foreach (var entry in imageInfo.ExifDictionary)
                    ImageExifMetadata.Add(entry.Key.ToString(), Tuple.Create(GetStringValue(entry), entry.Description));

                if (ImageExifMetadata.Count == 0)
                    ImageExifMetadata.Add("", Tuple.Create("", ""));

                foreach (var entry in imageInfo.IptcDictionary)
                    ImageIptcMetadata.Add(entry.Key.ToString(), Tuple.Create(GetStringValue(entry), entry.Description));

                if (ImageIptcMetadata.Count == 0)
                    ImageIptcMetadata.Add("", Tuple.Create("", ""));
            }
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