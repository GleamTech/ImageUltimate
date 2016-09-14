@Imports GleamTech.ImageUltimate.Web
@Imports GleamTech.Web.Mvc
@ModelType  GleamTech.ImageUltimateExamples.Mvc.VB.Models.OverviewViewModel

<!DOCTYPE html>

<html>
<head>
    <title>Overview</title>
    <style>
        table.info {
            background-color: white;
            border-collapse: collapse;
            margin-bottom: 20px;
            margin-left: 20px;
            float: left;
            min-width: 100px;
        }

            table.info caption {
                background-color: dodgerblue;
                color: white;
                font-weight: bold;
                padding: 2px;
            }

            table.info th,
            table.info td {
                text-align: left;
                padding: 8px;
                border: 1px solid #ddd;
            }

            table.info tr:nth-child(even) {
                background-color: #f2f2f2;
            }

        table.image img {
            background-image: url('data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAHAAAABwAQMAAAD8LmYIAAAABlBMVEXMzMz////TjRV2AAAAIklEQVQ4y2P4z4AMGejGZRggi0f9O+rfUf+O+nfUv4PSvwAQPQ0eTjYYlQAAAABJRU5ErkJggg==');
            background-repeat: repeat;
        }
    </style>
</head>
<body style="margin: 20px;">

    @Html.RenderControl(Model.ExampleFileSelector)

    <table class="info image">
        <caption>Thumbnail</caption>
        <tr>
            <td>@Html.Image(Model.ImagePath, Function(task) task.Thumbnail(160))</td>
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
