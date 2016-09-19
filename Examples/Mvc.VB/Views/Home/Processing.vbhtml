@Imports  GleamTech.ExamplesCore
@Imports GleamTech.ImageUltimate.Web
@Imports GleamTech.Web.Mvc
@ModelType  GleamTech.ImageUltimateExamples.Mvc.VB.Models.ProcessingViewModel

<!DOCTYPE html>

<html>
<head>
    <title>Image Processing</title>
    <link href="@ExamplesCoreConfiguration.GetVersionedUrl("~/resources/table.css")" rel="stylesheet" />
</head>
<body style="margin: 20px;">

    @Using (Html.BeginForm("Processing", "Home"))
        @Html.RenderControl(Model.ExampleFileSelector)

        @<p>
            Choose task @Html.DropDownList("taskSelector", Model.TaskSelectList, New With { .onchange = "this.form.submit();" })
        </p>
    End Using


    <table class="info image">
        <caption> Resulting Image</caption>
        <tr>
        <td>@Html.Image(Model.ImagePath, Model.TaskAction)</td>
        </tr>
    </table>

    <table class="info image">
        <caption> Original Image (Resized To width 300)</caption>
        <tr>
            <td>@Html.Image(Model.ImagePath, Function (task) task.ResizeWidth(300))</td>
        </tr>
    </table>

    <table class="info">
        <caption> Resulting Image Url</caption>
        <tr>
            <td>@Url.Image(Model.ImagePath, Model.TaskAction)</td>
        </tr>
    </table>

</body>
</html>
