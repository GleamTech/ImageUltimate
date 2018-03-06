# ![ImageUltimate Logo](imageultimate-logo.png) ImageUltimate: ASP.NET Image Resizer
ImageUltimate is the fastest and easiest ASP.NET Image Resizer which supports both ASP.NET MVC and ASP.NET WebForms web applications/web sites. ImageUltimate can also be used with .NET desktop applications for manipulating several image formats. Let your web site prepare images automagically for you. Save images once and embrace the responsive web.

- Chain image manipulation commands to get variations in the brink of an eye.

- Keep your source images in their original formats (eg. Psd, Raw) and serve the resulting images in any web format

- Have SEO friendly urls for your images to improve your rankings.

- Vastly reduce your outgoing bandwidth usage with the help of smart versioning.

![ASP.NET Document Viewer](imageultimate.png)

**Note:** This project contains a fully working version of the product, however without a license key it will run in trial mode. For more information, please see [ImageUltimate: ASP.NET Image Resizer](http://www.gleamtech.com/imageultimate) product page.

### Features:

*  Can load and save many image file formats (raster, vector and camera raw).

*   Provides a fluent interface for easily chaining image manipulation commands.

*   Vastly faster (10x) than System.Drawing namespace and optimized specifically for web use. Minimal memory usage and the ability to process very large images in a fast manner.

*   Provides detailed information about an image file like format, size, DPI, pixel format and metadata like EXIF and IPTC.

*   Fast thumbnail generation, smartly looks for a EXIF thumbnail, removes black stripes above and below it and resizes it down further if needed.

*   Provides these image transforms: Resize, LiquidResize (seam carving), Crop, TrimBorders, Rotate, Flip.

*   Provides these image color/tone corrections and filters: Brightness, Contrast, Enhance, Blur, Sharpen.

*   Caches generated images both on server and browser with a smart versioning algorithm. A unique and browser-cacheable url is generated according to the chained commands and whenever you change these commands (or modify the source image externally), the url will vary and this will cause browser to automatically detect changes (no need to press F5).

*   Generates SEO friendly urls. By default the file name of the source image is used but it's possible to override this file name for SEO purposes.

*   Single managed DLL (works both on 32-bit and 64-bit) for easy deployment and no dependencies. No messy Web.config settings. Just drop it in your bin folder and you are ready to go.

*   Strongly-typed API for web, no need to learn and memorize messy url querystring parameters, just chain commands with the help of intellisense.

### Supported Formats:
<table class="table table-bordered table-hover">

<thead>
  <tr class="info">
     <th>Format</th>
     <th>Extensions</th>
     <th class="text-center">Load</th>
     <th class="text-center">Save</th>
  </tr>
 </thead>
<tbody>

<tr>
    <th colspan="5" align="left">Raster Image Formats:</th>
</tr>

<tr>
    <td>Joint Photographic Experts Group (JPEG)</td>
    <td>.jpg, .jpeg, .jpe, .jif, .jfif, .jfi, .exif</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <td>JPEG 2000 (JP2)</td>
    <td>.jp2, .jpf, .jpx, .j2k, .j2c, .jpc</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <td>Portable Network Graphics (PNG)</td>
    <td>.png</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <td>Graphics Interchange Format (GIF)</td>
    <td>.gif</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <td>WebP Image</td>
    <td>.webp</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <td>Bitmap Picture (BMP)</td>
    <td>.bmp</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <td>Windows Metafile (WMF)</td>
    <td>.wmf</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Device Independent Bitmap (DIB)</td>
    <td>.dib</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <td>Windows Icon (ICO)</td>
    <td>.ico</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <td>Truevision Graphics Adapter (TARGA)</td>
    <td>.tga</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <td>Adobe Photoshop Document (PSD)</td>
    <td>.psd, .psb</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <th colspan="5" align="left">Scanner Image Formats:</th>
</tr>

<tr>
    <td>Tagged Image File Format (TIFF)</td>
    <td>.tif, .tiff, .tff</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <th colspan="5" align="left">Vector Image Formats:</th>
</tr>

<tr>
    <td>Scalable Vector Graphics (SVG)</td>
    <td>.svg</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center">&#x2713;</td>
</tr>

<tr>
    <td>Windows Enhanced Metafile (EMF)</td>
    <td>.emf</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <th colspan="5" align="left">Camera Image Formats:</th>
</tr>

<tr>
    <td>Adobe Digital Negative (Leica)</td>
    <td>.dng</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Sony Alpha Raw Image Format</td>
    <td>.arw</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Sony Raw Format</td>
    <td>.sr2, .srf</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Canon Digital Camera Raw Image Format</td>
    <td>.cr2, .crw</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Nikon Digital SLR Camera Raw Image File</td>
    <td>.nef, .nrw</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Fuji CCD-RAW Graphic File</td>
    <td>.raf</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Olympus Digital Camera Raw Image File</td>
    <td>.orf</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Pentax Electronic File</td>
    <td>.pef</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Kodak Digital Camera Raw Image Format</td>
    <td>.kdc</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Kodak Digital Camera Raw Image Format</td>
    <td>.dcr</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Minolta/Konica Minolta Raw Image File</td>
    <td>.mrw</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Epson RAW Format</td>
    <td>.erf</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Panasonic Lumix Raw Image</td>
    <td>.rw2</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Samsung Raw Format</td>
    <td>.srw</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Sigma Camera RAW Picture File</td>
    <td>.x3f</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Mamiya Raw Image File</td>
    <td>.mef</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <td>Camera Raw Image File</td>
    <td>.raw</td>
    <td class="text-center">&#x2713;</td>
    <td class="text-center"></td>
</tr>

<tr>
    <th colspan="5" align="left">Totals:</th>
</tr>
<tr>
    <td>31</td>
    <td>48</td>
    <td class="text-center">31</td>
    <td class="text-center">12</td>
</tr>
</tbody>
</table>


### To use ImageUltimate in an ASP.NET MVC Project, do the following in Visual Studio:

1.  Add references to ImageUltimate assemblies. There are two ways to perform this:

    -   Add reference to **GleamTech.Core.dll** and **GleamTech.ImageUltimate.dll** found in "Bin" folder of ImageUltimate-vX.X.X.X.zip package which you already downloaded and extracted.

    -   Or install NuGet package and add references automatically via NuGet Package Manager in Visual Studio: 
        Go to **Tools -> NuGet Package Manager -> Package Manager Console** and run this command:

        `Install-Package ImageUltimate -Source https://get.gleamtech.com/nuget/default/`

        If you prefer using the user interface when working with NuGet, you can also install the package this way:
		
        -  GleamTech has its own NuGet feed so first you need to add this feed to be able to find GleamTech's packages. 
           Go to **Tools -> NuGet Package Manager -> Package Manager Settings** and then click the **+** button to add a 
			    new package source. Enter `GleamTech` in **Name** field and `https://get.gleamtech.com/nuget/default/` 
			    in **Source** field and click **OK**.
			    
        -  Go to **Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution**, select `GleamTech` or `All` 
			   in the Package source dropdown on the top right. Now enter `ImageUltimate` in the search field, 
			   and click **Install** button on the found package.

2.  Set ImageUltimate's global configuration. For example, you may want to set the license key and the default path for finding source images (SourcePath). Insert some of the following lines (if overriding a default value is required) into the ```Application_Start``` method of your **Global.asax.cs**:

    ```c#
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

    //The default CacheLocation value is "~/App_Data/ImageCache"
    //Both virtual and physical paths are allowed (or a Location instance for one of the supported 
    //file systems like Amazon S3 and Azure Blob).
    //However it's recommended that you use a path inside your application folder 
    //(e.g. "~/SomeFolder", "/SomeFolder" or "C:\inetpub\wwwroot\MySite\SomeFolder")
    //so that ImageUltimate can use RewritePath to pass download requests directly
    //to IIS for higher throughput.
    ImageUltimateWebConfiguration.Current.CacheLocation = "~/App_Data/ImageCache";
    ```

    Alternatively you can specify the configuration in ```<appSettings>``` tag of your Web.config.

    ```xml
    <add key="ImageUltimate:LicenseKey" value="QQJDJLJP34..." />
    <add key="ImageUltimateWeb:SourcePath" value="~/Content" />
    <add key="ImageUltimateWeb:CacheLocation" value="~/App_Data/ImageCache" />
    ```

    As you would notice, ```ImageUltimate:``` prefix maps to ```ImageUltimateConfiguration.Current``` and ```ImageUltimateWeb:``` prefix maps to ```ImageUltimateWebConfiguration.Current```.

3.  Open one of your View pages (eg. Index.cshtml) and at the top of your page add the necessary namespaces:

    ```cshtml
    @using GleamTech.ImageUltimate
    @using GleamTech.ImageUltimate.AspNet
    @using GleamTech.ImageUltimate.AspNet.Mvc
    ```

    Alternatively you can add the namespaces globally in **Views/web.config** under 
    `<system.web.webPages.razor>/<pages>/<namespaces>` tag to avoid adding namespaces in your pages every time:

    ```xml
    <add namespace="GleamTech.ImageUltimate" />
    <add namespace="GleamTech.ImageUltimate.AspNet" />
    <add namespace="GleamTech.ImageUltimate.AspNet.Mvc" />
    ```

    Now in your page insert these lines:

    ```cshtml
    @this.ImageTag("SomeImage.jpg", task => task.ResizeWidth(300))
    ```

    This will resize width of the source image "~/Content/SomeImage.jpg" to 300 pixels (keeping aspect ratio), cache the resulting image and render a <img> tag in your page. For consecutive page views, the image will be served directly from the cache and no processing will be done. This is the reason the task (second parameter) is specified as a lambda function, it will be only called when necessary for maximum performance. Note that as we specified a non-rooted path for the image path (first parameter), the image is considered relative to ImageUltimateWebConfiguration.Current.SourcePath (as set in step 2). This allows you to write image commands as short lines and avoids parent path repetition.

    Sometimes you may need to render a url instead of a <img> tag, then use:

    ```cshtml
    @this.ImageUrl("SomeImage.jpg", task => task.ResizeWidth(300))
    ```
    
    For example, consider you want to add a background image to a CSS class:
    
    ```html
    <style>
    .someCls
    {
        background-image: url(@this.ImageUrl("SomeImage.jpg", task => task.ResizeWidth(300)));
    }
    </style> 
    ```

### To use ImageUltimate in an ASP.NET WebForms Project, do the following in Visual Studio:

1.  Add references to ImageUltimate assemblies. There are two ways to perform this:

    -   Add reference to **GleamTech.Core.dll** and **GleamTech.ImageUltimate.dll** found in "Bin" folder of ImageUltimate-vX.X.X.X.zip package which you already downloaded and extracted.

    -   Or install NuGet package and add references automatically via NuGet Package Manager in Visual Studio: 
        Go to **Tools -> NuGet Package Manager -> Package Manager Console** and run this command:

        `Install-Package ImageUltimate -Source https://get.gleamtech.com/nuget/default/`

        If you prefer using the user interface when working with NuGet, you can also install the package this way:
		
        -  GleamTech has its own NuGet feed so first you need to add this feed to be able to find GleamTech's packages. 
           Go to **Tools -> NuGet Package Manager -> Package Manager Settings** and then click the **+** button to add a 
			    new package source. Enter `GleamTech` in **Name** field and `https://get.gleamtech.com/nuget/default/` 
			    in **Source** field and click **OK**.
			    
        -  Go to **Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution**, select `GleamTech` or `All` 
			   in the Package source dropdown on the top right. Now enter `ImageUltimate` in the search field, 
			   and click **Install** button on the found package.

2.  Set ImageUltimate's global configuration. For example, you may want to set the license key and the default path for finding source images (SourcePath). Insert some of the following lines (if overriding a default value is required) into the ```Application_Start``` method of your **Global.asax.cs**:

    ```cshtml
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

    //The default CacheLocation value is "~/App_Data/ImageCache"
    //Both virtual and physical paths are allowed (or a Location instance for one of the supported 
    //file systems like Amazon S3 and Azure Blob).
    //However it's recommended that you use a path inside your application folder 
    //(e.g. "~/SomeFolder", "/SomeFolder" or "C:\inetpub\wwwroot\MySite\SomeFolder")
    //so that ImageUltimate can use RewritePath to pass download requests directly
    //to IIS for higher throughput.
    ImageUltimateWebConfiguration.Current.CacheLocation = "~/App_Data/ImageCache"; 
    ```

    Alternatively you can specify the configuration in ```<appSettings>``` tag of your Web.config.

    ```xml
    <add key="ImageUltimate:LicenseKey" value="QQJDJLJP34..." />
    <add key="ImageUltimateWeb:SourcePath" value="~/Content" />
    <add key="ImageUltimateWeb:CacheLocation" value="~/App_Data/ImageCache" />
    ```

    As you would notice, ```ImageUltimate:``` prefix maps to ```ImageUltimateConfiguration.Current``` and ```ImageUltimateWeb:``` prefix maps to ```ImageUltimateWebConfiguration.Current```.

3.  Open one of your pages (eg. Default.aspx) and at the top of your page add add the necessary namespaces:

    ```aspx
    <%@ Import Namespace="GleamTech.ImageUltimate" %>
    <%@ Import Namespace="GleamTech.ImageUltimate.AspNet" %>
    <%@ Import Namespace="GleamTech.ImageUltimate.AspNet.WebForms" %>
    ```

    Alternatively you can add the namespaces globally in **Web.config** under 
    `<system.web>/<pages>/<namespaces>` tag to avoid adding namespaces in your pages every time:

    ```xml
    <add namespace="GleamTech.ImageUltimate" />
    <add namespace="GleamTech.ImageUltimate.AspNet" />
    <add namespace="GleamTech.ImageUltimate.AspNet.WebForms" />
    ```

    Now in your page insert these lines:

    ```aspx
    <%=this.ImageTag("SomeImage.jpg", task => task.ResizeWidth(300))%>
    ```

    This will resize width of the source image "~/Content/SomeImage.jpg" to 300 pixels (keeping aspect ratio), cache the resulting image and render a <img> tag in your page. For consecutive page views, the image will be served directly from the cache and no processing will be done. This is the reason the task (second parameter) is specified as a lambda function, it will be only called when necessary for maximum performance. Note that as we specified a non-rooted path for the image path (first parameter), the image is considered relative to ImageUltimateWebConfiguration.Current.SourcePath (as set in step 2). This allows you to write image commands as short lines and avoids parent path repetition.

    Sometimes you may need to render a url instead of a <img> tag, then use:

    ```aspx
    <%=this.ImageUrl("SomeImage.jpg", task => task.ResizeWidth(300))%>
    ```

    For example, consider you want to add a background image to a CSS class:

    ```html
    <style>
        .someCls
        {
            background-image: url(<%=this.ImageUrl("SomeImage.jpg", task => task.ResizeWidth(300))%>);
        }
    </style>
    ```
