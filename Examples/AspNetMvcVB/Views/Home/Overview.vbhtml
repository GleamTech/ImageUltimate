@Imports GleamTech.AspNet.Mvc
@Imports GleamTech.Examples
@Imports GleamTech.ImageUltimate.AspNet.Mvc
@ModelType  GleamTech.ImageUltimateExamples.AspNetMvcVB.Models.OverviewViewModel

<!DOCTYPE html>

<html>
<head>
    <title>Overview</title>
    <link href="@ExamplesConfiguration.GetVersionedUrl("~/resources/table.css")" rel="stylesheet" />
</head>
<body style="margin: 20px;">

    @Me.RenderBody(Model.ExampleFileSelector)

    <table class="info image">
        <caption>Thumbnail</caption>
        <tr>
            <td>@Me.ImageTag(Model.ImagePath, Function(task) task.Thumbnail(160))</td>
        </tr>
    </table>

    <table class="info">
        <caption>Image Info</caption>
        @For Each kvp In Model.ImageData
        @<tr>
            <th>@kvp.Key</th>
            <td>@kvp.Value</td>
        </tr>
        Next
    </table>

    <table class="info">
        <caption>Image EXIF Metadata</caption>
        @For Each kvp in Model.ImageExifMetadata
        @<tr>
            <th>@kvp.Key</th>
            <td>@kvp.Value.Item1</td>
            <td>@kvp.Value.Item2</td>
        </tr>
        Next
    </table>

    <table class="info">
        <caption>Image IPTC Metadata</caption>
        @For Each kvp in Model.ImageIptcMetadata
        @<tr>
            <th>@kvp.Key</th>
            <td>@kvp.Value.Item1</td>
            <td>@kvp.Value.Item2</td>
        </tr>
        Next
    </table>

</body>
</html>
