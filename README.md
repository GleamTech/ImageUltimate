# ![ImageUltimate Logo](imageultimate-logo.png) ImageUltimate: ASP.NET Image Resizer
ImageUltimate is the fastest and easiest ASP.NET Image Resizer which supports both ASP.NET MVC and ASP.NET WebForms web applications/web sites. ImageUltimate can also be used with .NET desktop applications for manipulating several image formats. Let your web site prepare images automagically for you. Save images once and embrace the responsive web.

- Chain image manipulation commands to get variations in the brink of an eye.

- Keep your source images in their original formats (eg. Psd, Raw) and serve the resulting images in any web format

- Have SEO friendly urls for your images to improve your rankings.

- Vastly reduce your outgoing bandwidth usage with the help of smart versioning.

![ASP.NET Document Viewer](imageultimate.png)

**Note:** This project contains a fully working version of the product, however without a license key it will run in trial mode. For more information, please see [ImageUltimate: ASP.NET Image Resizer](http://www.gleamtech.com/imageultimate) product page.

### Features:

*   Provides a fluent interface for easily chaining image manipulation commands.

*   Processes images stripe by stripe so avoids keeping a full sized bitmap in RAM. This means minimal memory usage and the ability to process very large images in a fast manner.

*   Vastly faster (10x) than System.Drawing namespace and optimized specifically for web use.

*   Can load these image file formats:

    *   Jpeg (Joint Photographic Experts Group)

    *   Png (Portable Network Graphics)

    *   Gif (Graphics Interchange Format)

    *   WebP (Google's Image Format)

    *   Bmp (Bitmap Picture)

    *   Tiff (Tagged Image File Format)

    *   Tga (Truevision Graphics Adapter)

    *   Eps (Encapsulated PostScript) - TIFF Preview only

    *   Psd (Photoshop Document) and Psb Photoshop Large Document Format)

    *   Raw (Digital Camera Image Formats):

        *   dng (Adobe)

        *   arw, srf, sr2 (Sony)

        *   cr2 (Canon)

        *   nef, nrw (Nikon)

        *   raf (Fuji)

        *   orf (Olympus)

        *   pef (Pentax)

        *   kdc, dcr (Kodak)

        *   mrw (Minolta)

        *   erf (Epson)

        *   rw2 (Panasonic)

        *   dng (Leica)

        *   srw (Samsung)

        *   x3f (Sigma)

*   Can save these image file formats:

    *   Jpeg (Joint Photographic Experts Group)

    *   Png (Portable Network Graphics)

    *   Gif (Graphics Interchange Format)

    *   WebP (Google's Image Format)

    *   Bmp (Bitmap Picture)

    *   Tiff (Tagged Image File Format)

    *   Tga (Truevision Graphics Adapter)

    *   Eps (Encapsulated PostScript)

    *   Pdf (Portable Document Format)

*   Provides detailed information about an image file like format, size, DPI, pixel format and metadata like EXIF and IPTC.

*   Fast thumbnail generation, smartly looks for a EXIF thumbnail, removes black stripes above and below it and resizes it down further if needed.

*   Provides these image transforms: Resize, ResizeWidth, ResizeHeight, Crop, CropBorders, Rotate, Flip

*   Provides these image color and tone corrections: Brightness, BrightnessAuto, Contrast, ContrastAuto, BrightnessContrast

*   Caches generated images both on server and browser with a smart versioning algorithm. A unique and browser-cacheable url is generated according to the chained commands and whenever you change these commands (or modify the source image externally), the url will vary and this will cause browser to automatically detect changes (no need to press F5).

*   Generates SEO friendly urls. By default the file name of the source image is used but it's possible to override this file name for SEO purposes.

*   Single managed DLL (works both on 32-bit and 64-bit) for easy deployment and no dependencies. No messy Web.config settings. Just drop it in your bin folder and you are ready to go.

*   Strongly-typed API for web, no need to learn and memorize messy url querystring parameters, just chain commands with the help of intellisense.

### To use ImageUltimate in an ASP.NET MVC Project, do the following in Visual Studio:

1.  Add references to ImageUltimate assemblies. There are two ways to perform this:

    -   Add reference to **GleamTech.Core.dll** and **GleamTech.ImageUltimate.dll** found in "Bin" folder of ImageUltimate-vX.X.X.X.zip package which you already downloaded and extracted.

    -   Or install NuGet package and add references automatically via NuGet Package Manager in Visual Studio: open **Tools -&gt; NuGet Package Manager -&gt; Package Manager Console** and run this command:

        `Install-Package ImageUltimate`

        If you prefer using the user interface when working with NuGet, you can also install the package this way: open **Tools -&gt; NuGet Package Manager -&gt; Manage NuGet Packages for Solution**, enter **ImageUltimate** in the search field, and click **Install** button on the found package.

2.  Set ImageUltimate's global configuration. For example, you may want to set the license key and the default path for finding source images (SourcePath). Insert some of the following lines (if overriding a default value is required) into the ```Application_Start``` method of your **Global.asax.cs**:

    ```
    //Set this property only if you have a valid license key, otherwise do not
    //set it so ImageUltimate runs in trial mode.
    ImageUltimateConfiguration.Current.LicenseKey = "QQJDJLJP34...";

    //The default SourcePath value is "~/App_Data/ImageSource"
    //Both virtual and physical paths are allowed.
    //Note that using a path under "~/App_Data" can have a benefit,
    //for instance if you want to protect your original source files, i.e.
    //prevent them from being downloaded directly, you can use this special 
    //folder which is restricted by ASP.NET runtime by default.
    ImageUltimateWebConfiguration.Current.SourcePath = "~/Content";

    //The default CachePath value is "~/App_Data/ImageCache"
    //Both virtual and physical paths are allowed.
    //However it's recommended that you use a path inside your application folder 
    //so that ImageUltimate can use RewritePath to pass download requests directly
    //to IIS for higher throughput.
    ImageUltimateWebConfiguration.Current.CachePath = "~/App_Data/ImageCache";    
    ```

    Alternatively you can specify the configuration in ```<appSettings>``` tag of your Web.config.

    ```
    <appSettings>
      <add key="ImageUltimate:LicenseKey" value="QQJDJLJP34..." />
      <add key="ImageUltimateWeb:SourcePath" value="~/Content" />
      <add key="ImageUltimateWeb:CachePath" value="~/App_Data/ImageCache" />
    </appSettings>
    ```

    As you would notice, ```ImageUltimate:``` prefix maps to ```ImageUltimateConfiguration.Current``` and ```ImageUltimateWeb:``` prefix maps to ```ImageUltimateWebConfiguration.Current```.

3.  Open one of your View pages (eg. Index.cshtml) and at the top of your page add GleamTech.ImageUltimate.Web namespace (sometimes you will also need GleamTech.ImageUltimate namespace):

    ```
    @using GleamTech.ImageUltimate.Web
    ```

    Alternatively you can add the namespaces globally in **Views/web.config** to avoid adding namespaces in your pages every time:

    ```
    <system.web.webPages.razor>
      <pages pageBaseType="System.Web.Mvc.WebViewPage">
        <namespaces>
          .
          .
          .
          <add namespace="GleamTech.ImageUltimate" />
          <add namespace="GleamTech.ImageUltimate.Web" />
        </namespaces>
      </pages>
    </system.web.webPages.razor>    
    ```

    Now in your page insert these lines:

    ```
    @Html.Image("SomeImage.jpg", task => task.ResizeWidth(300))
    ```

    This will resize width of the source image "~/Content/SomeImage.jpg" to 300 pixels (keeping aspect ratio), cache the resulting image and render a <img> tag in your page. For consecutive page views, the image will be served directly from the cache and no processing will be done. This is the reason the task (second parameter) is specified as a lambda function, it will be only called when necessary for maximum performance. Note that as we specified a non-rooted path for the image path (first parameter), the image is considered relative to ImageUltimateWebConfiguration.Current.SourcePath (as set in step 2). This allows you to write image commands as short lines and avoids parent path repetition.

    Sometimes you may need to render a url instead of a <img> tag, then use Url.Image:

    ```
    @Url.Image("SomeImage.jpg", task => task.ResizeWidth(300))
    ```
    
    For example, consider you want to add a background image to a CSS class:
    
    ```
    <style>
      .someCls 
      {
          background-image: url(@Url.Image("SomeImage.jpg", task => task.ResizeWidth(300)));
      }
    </style>    
    ```

### To use ImageUltimate in an ASP.NET WebForms Project, do the following in Visual Studio:

1.  Add references to ImageUltimate assemblies. There are two ways to perform this:

    -   Add reference to **GleamTech.Core.dll** and **GleamTech.ImageUltimate.dll** found in "Bin" folder of ImageUltimate-vX.X.X.X.zip package which you already downloaded and extracted.

    -   Or install NuGet package and add references automatically via NuGet Package Manager in Visual Studio: open **Tools -&gt; NuGet Package Manager -&gt; Package Manager Console** and run this command:

        `Install-Package ImageUltimate`

        If you prefer using the user interface when working with NuGet, you can also install the package this way: open **Tools -&gt; NuGet Package Manager -&gt; Manage NuGet Packages for Solution**, enter **ImageUltimate**, in the search field, and click **Install** button on the found package.

2.  Set ImageUltimate's global configuration. For example, you may want to set the license key and the default path for finding source images (SourcePath). Insert some of the following lines (if overriding a default value is required) into the ```Application_Start``` method of your **Global.asax.cs**:

    ```
    //Set this property only if you have a valid license key, otherwise do not
    //set it so ImageUltimate runs in trial mode.
    ImageUltimateConfiguration.Current.LicenseKey = "QQJDJLJP34...";

    //The default SourcePath value is "~/App_Data/ImageSource"
    //Both virtual and physical paths are allowed.
    //Note that using a path under "~/App_Data" can have a benefit,
    //for instance if you want to protect your original source files, i.e.
    //prevent them from being downloaded directly, you can use this special 
    //folder which is restricted by ASP.NET runtime by default.
    ImageUltimateWebConfiguration.Current.SourcePath = "~/Content";

    //The default CachePath value is "~/App_Data/ImageCache"
    //Both virtual and physical paths are allowed.
    //However it's recommended that you use a path inside your application folder 
    //so that ImageUltimate can use RewritePath to pass download requests directly
    //to IIS for higher throughput.
    ImageUltimateWebConfiguration.Current.CachePath = "~/App_Data/ImageCache";    
    ```

    Alternatively you can specify the configuration in ```<appSettings>``` tag of your Web.config.

    ```
    <appSettings>
      <add key="ImageUltimate:LicenseKey" value="QQJDJLJP34..." />
      <add key="ImageUltimateWeb:SourcePath" value="~/Content" />
      <add key="ImageUltimateWeb:CachePath" value="~/App_Data/ImageCache" />
    </appSettings>
    ```

    As you would notice, ```ImageUltimate:``` prefix maps to ```ImageUltimateConfiguration.Current``` and ```ImageUltimateWeb:``` prefix maps to ```ImageUltimateWebConfiguration.Current```.

3.  Open one of your pages (eg. Default.aspx) and at the top of your page add GleamTech.ImageUltimate.Web namespace (sometimes you will also need GleamTech.ImageUltimate namespace):

    ```
    <%@ Import Namespace="GleamTech.ImageUltimate.Web" %>
    ```

    Alternatively you can add the namespaces globally in **Web.config** to avoid adding namespaces in your pages every time:

    ```
    <system.web>
      <pages>
        <namespaces>
          .
          .
          .
          <add namespace="GleamTech.ImageUltimate" />
          <add namespace="GleamTech.ImageUltimate.Web" />
        </namespaces>
      </pages>
    </system.web>
    ```

    Now in your page insert these lines:

    ```
    <%=Page.ImageHtml("SomeImage.jpg", task => task.ResizeWidth(300))%>
    ```

    This will resize width of the source image "~/Content/SomeImage.jpg" to 300 pixels (keeping aspect ratio), cache the resulting image and render a <img> tag in your page. For consecutive page views, the image will be served directly from the cache and no processing will be done. This is the reason the task (second parameter) is specified as a lambda function, it will be only called when necessary for maximum performance. Note that as we specified a non-rooted path for the image path (first parameter), the image is considered relative to ImageUltimateWebConfiguration.Current.SourcePath (as set in step 2). This allows you to write image commands as short lines and avoids parent path repetition.

    Sometimes you may need to render a url instead of a <img> tag, then use Page.ImageUrl:

    ```
    <%=Page.ImageUrl("SomeImage.jpg", task => task.ResizeWidth(300))%>
    ```

    For example, consider you want to add a background image to a CSS class:

    ```
    <style>
      .someCls 
      {
          background-image: url(<%=Page.ImageUrl("SomeImage.jpg", task => task.ResizeWidth(300))%>);
      }
    </style>
    ```
