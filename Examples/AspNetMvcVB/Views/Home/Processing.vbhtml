@Imports GleamTech.AspNet.Mvc
@Imports GleamTech.Examples
@Imports GleamTech.ImageUltimate.AspNet.Mvc
@ModelType  GleamTech.ImageUltimateExamples.AspNetMvcVB.Models.ProcessingViewModel

<!DOCTYPE html>

<html>
<head>
    <title>Image Processing</title>
    <link href="@ExamplesConfiguration.GetVersionedUrl("~/resources/table.css")" rel="stylesheet" />
    <script type="text/javascript">
        function showImageSize(img, targetId) {
            if (!img.complete)
                return;
            if (typeof img.naturalWidth != "undefined" && img.naturalWidth === 0)
                return;

            var width = img.naturalWidth || img.width;
            var height = img.naturalHeight || img.height;

            document.getElementById(targetId).innerHTML = width + "x" + height;
        }
    </script>
</head>
<body style="margin: 20px;">

    @Using (Html.BeginForm("Processing", "Home"))
        @(Me.RenderBody(Model.ExampleFileSelector))

        @<p>
            Choose task @Html.DropDownList("taskSelector", Model.TaskSelectList, New With {.onchange = "this.form.submit();"})
        </p>
    End Using

    <table class="info image">
        <caption>Resulting Image (<span id="outputSize"></span>)</caption>
        <tr>
            <td>@Me.ImageTag(Model.ImagePath, Model.TaskAction, New With {.onload = "showImageSize(this, 'outputSize')"})</td>
        </tr>
    </table>

    <table class="info image">
        <caption>Original Image (Resized to <span id="inputSize"></span>)</caption>
        <tr>
            <td>@Me.ImageTag(Model.ImagePath, Function(task) task.ResizeWidth(400), New With {.onload = "showImageSize(this, 'inputSize')"})</td>
        </tr>
    </table>

    <div class="clear"></div>

    <table class="info">
        <caption>Code</caption>
        <tr>
            <td><pre>@Model.CodeString</pre></td>
        </tr>
    </table>

    <div class="clear"></div>

    <table class="info">
        <caption>Resulting Image Url</caption>
        <tr>
            <td><pre>@Me.ImageUrl(Model.ImagePath, Model.TaskAction)</pre></td>
        </tr>
    </table>

</body>
</html>
