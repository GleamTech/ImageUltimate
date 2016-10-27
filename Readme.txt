ImageUltimate v1.8.7 - ASP.NET Image Resizer
Copyright © 2015-2016 GleamTech
http://www.gleamtech.com/imageultimate

---------------------------------------------------
Information on package:
---------------------------------------------------

Fastest and easiest ASP.NET image processing library. Both ASP.NET WebForms and ASP.NET MVC 3+ (.NET Framework 4.0+) are supported. The library can also be used with .NET desktop applications as web specific features are separated into Web sub-namespace.
    
Features:

- Provides a fluent interface for easily chaining image manipulation commands.

- Processes images stripe by stripe so avoids keeping a full sized bitmap in RAM. This means minimal memory usage and the ability to process very large images in a fast manner.

- Vastly faster (10x) than System.Drawing namespace and optimized specifically for web use.

- Can load these image file formats: Jpeg, Png, Gif, WebP, Bmp, Tiff, Eps, Psd, Raw

- Can save these image file formats: Jpeg, Png, Gif, WebP, Bmp, Tiff, Eps, Pdf

- Provides detailed information about an image file like format, size, DPI, pixel format and metadata like EXIF and IPTC.

- Provides these image transforms: Resize, ResizeWidth, ResizeHeight, Crop, CropBorders, Rotate, Flip

- Provides these image color and tone corrections: Brightness, BrightnessAuto, Contrast, ContrastAuto, BrightnessContrast

- Caches generated images both on server and browser with a smart versioning algorithm. A unique and browser-cacheable url is generated according to the chained commands and whenever you change these commands (or modify the source image externally), the url will vary and this will cause browser to automatically detect changes (no need to press F5).

- Generates SEO friendly urls. By default the file name of the source image is used but it's possible to override this file name for SEO purposes.

- Single DLL for easy deployment and no dependencies. No messy Web.config settings. Just drop it in your bin folder and you are ready to go.

- Strongly-typed API for web, no need to learn and memorize messy url querystring parameters, just chain commands with the help of intellisense.
    
ASP.NET MVC usage examples:

    @using GleamTech.ImageUltimate
    @using GleamTech.ImageUltimate.Web

    @Html.Image("Image1.jpg", task => task.ResizeWidth(300))
    @Html.Image("Image2.png", task => task.ResizeHeight(300).Rotate(45))
    @Html.Image("Image3.jpg", task => task.Flip(FlipMode.Vertical), new { alt = "description"})
    @Html.Image("Image4.jpg", task => task.Brightness(50).FileName("seo-name"))
    Image url: @Url.Image("Image5.jpg", task => task.Crop(0, 0, 100, 100).Format(ImageSaveFormat.Png))

ASP.NET WebForms usage examples:

    <%@ Import Namespace="GleamTech.ImageUltimate" %>
    <%@ Import Namespace="GleamTech.ImageUltimate.Web" %>

    <%=Page.ImageHtml("Image1.jpg", task => task.ResizeWidth(300)) %>
    <%=Page.ImageHtml("Image3.jpg", task => task.Flip(FlipMode.Vertical), new { alt = "description"}) %>
    Image url: <%=Page.ImageUrl("Image1.jpg", task => task.Contrast(-20)) %>

General usage examples:

    using GleamTech.ImageUltimate;

    using (var imageTask = new ImageTask(@"C:\Pictures\Picture1.jpg"))
        imageTask.ResizeWidth(200).Save(@"C:\Output\Picture2.jpg");

    using (var imageTask = new ImageTask(@"C:\Pictures\Picture1.jpg"))
        imageTask
        .ResizeWidth(200).Save(@"C:\Output\Picture2.jpg")
        .Undo().ResizeHeight(400).Rotate(90).Save(@"C:\Output\Picture3.png")
        .UndoAll().Save(outputStream, ImageSaveFormat.Pdf);

    using (var imageInfo = new ImageInfo(@"C:\Pictures\Picture1.jpg"))
    {
        Console.WriteLine("Info:");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Format: " + imageInfo.Format);
        Console.WriteLine("Width: " + imageInfo.Width);
        Console.WriteLine("Height: " + imageInfo.Height);
        Console.WriteLine("DpiX: " + imageInfo.DpiX);
        Console.WriteLine("DpiY: " + imageInfo.DpiY);
        Console.WriteLine("PixelFormat-Description: " + imageInfo.PixelFormatInfo.Description);
        Console.WriteLine("PixelFormat-ColorModel: " + imageInfo.PixelFormatInfo.ColorModel);
        Console.WriteLine("PixelFormat-BitDepth: " + imageInfo.PixelFormatInfo.BitDepth);
        Console.WriteLine("PixelFormat-HasAlpha: " + imageInfo.PixelFormatInfo.HasAlpha);
        Console.WriteLine("PixelFormat-IsIndexed: " + imageInfo.PixelFormatInfo.IsIndexed);
        Console.WriteLine("PixelFormat-IsRgb: " + imageInfo.PixelFormatInfo.IsRgb);
        Console.WriteLine("PixelFormat-IsExtended: " + imageInfo.PixelFormatInfo.IsExtended);
        Console.WriteLine("PixelFormat-ChannelCount: " + imageInfo.PixelFormatInfo.ChannelCount);
        Console.WriteLine("PixelFormat-MaxChannelValue: " + imageInfo.PixelFormatInfo.MaxChannelValue);

        Console.WriteLine();
        Console.WriteLine("Exif:");
        Console.WriteLine("----------------------------");
        foreach (var entry in imageInfo.ExifDictionary)
        {
            Console.WriteLine("Key: " + entry.Key);
            Console.WriteLine("Value: " + entry.Value);
            Console.WriteLine("ValueString: " + entry.ValueString);
            Console.WriteLine("Values: " + string.Join(",", entry.Values));
            Console.WriteLine("Description: " + entry.Description);
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Iptc:");
        Console.WriteLine("----------------------------");
        foreach (var entry in imageInfo.IptcDictionary)
        {
            Console.WriteLine("Key: " + entry.Key);
            Console.WriteLine("Value: " + entry.Value);
            Console.WriteLine("ValueString: " + entry.ValueString);
            Console.WriteLine("Values: " + string.Join(",", entry.Values));
            Console.WriteLine("Description: " + entry.Description);
            Console.WriteLine();
        }
    }

Configuration:

  License key can be set via this static method:

    ImageConfiguration.SetLicenseKey("QQJDJLJP34...");
    
  Web related configuration can be changed via static ImageWebConfiguration class:
   
    ImageWebConfiguration.SetCachePath("..."); //Default value is ~/App_Data/ImageCache
    ImageWebConfiguration.SetSourcePath("..."); //Default value is ~/App_Data/ImageSource

  These methods should be called globally, eg. in Application_Start method of Global.asax.
  The source path is for convenience. Whenever a plain file name (eg. Picture.jpg) or a non-rooted path (eg. SomeFolder/Picture.jpg) is given for a image loading/processing method, it will considered relative to this source path. If the given path is rooted (eg ~/Picture.jpg, /SomeFolder/Picture.jpg or C:\SomeFolder\Picture.jpg), this source path will be ignored for that method call.

Online documentation:

http://docs.gleamtech.com/imageultimate/

Note: This package contains a fully working version of the product, however without a license key it will run in trial mode. This  means after 30 days, the generated images will be watermarked with a red "ImageUltimate" text at the bottom right corner. If you deploy to IIS and see the watermark before your trial expires, set "Load User Profile" setting to true in "Advanced Settings" of the application pool.