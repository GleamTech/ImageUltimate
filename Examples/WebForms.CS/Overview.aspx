<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Overview.aspx.cs" Inherits="GleamTech.ImageUltimateExamples.WebForms.CS.OverviewPage" %>
<%@ Register TagPrefix="GleamTech" Namespace="GleamTech.ExamplesCore" Assembly="GleamTech.ExamplesCore" %>
<%@ Import Namespace="GleamTech.ImageUltimate.Web" %>

<!DOCTYPE html>

<html>
<head runat="server">
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

        table.info tr:nth-child(even){background-color: #f2f2f2}

        table.image img {
            background-image: url('data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAHAAAABwAQMAAAD8LmYIAAAABlBMVEXMzMz////TjRV2AAAAIklEQVQ4y2P4z4AMGejGZRggi0f9O+rfUf+O+nfUv4PSvwAQPQ0eTjYYlQAAAABJRU5ErkJggg==');
            background-repeat: repeat;
        }
    </style>
</head>
<body style="margin: 20px;">

    <GleamTech:ExampleFileSelector ID="exampleFileSelector" runat="server"
        InitialFile="JPG Image.jpg" />
    
    <table class="info image">
        <caption>Thumbnail</caption>
        <tr>
            <td><%=Page.ImageHtml(ImagePath, task => task.Thumbnail(160))%></td>
        </tr>
    </table>

    <table class="info">
        <caption>Image Info</caption>
        <% foreach (var kvp in ImageData) {%>
        <tr>
            <th><%=kvp.Key%></th>
            <td><%=kvp.Value%></td>
        </tr>
        <%}%>
    </table>
    
    <table class="info">
        <caption>Image EXIF Metadata</caption>
        <% foreach (var kvp in ImageExifMetadata) {%>
        <tr>
            <th><%=kvp.Key%></th>
            <td><%=kvp.Value.Item1%></td>
            <td><%=kvp.Value.Item2%></td>
        </tr>
        <%}%>
    </table>
    
    <table class="info">
        <caption>Image IPTC Metadata</caption>
        <% foreach (var kvp in ImageIptcMetadata) {%>
        <tr>
            <th><%=kvp.Key%></th>
            <td><%=kvp.Value.Item1%></td>
            <td><%=kvp.Value.Item2%></td>
        </tr>
        <%}%>
    </table>

</body>
</html>
