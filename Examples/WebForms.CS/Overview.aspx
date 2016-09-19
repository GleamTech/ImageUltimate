<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Overview.aspx.cs" Inherits="GleamTech.ImageUltimateExamples.WebForms.CS.OverviewPage" %>
<%@ Register TagPrefix="GleamTech" Namespace="GleamTech.ExamplesCore" Assembly="GleamTech.ExamplesCore" %>
<%@ Import Namespace="GleamTech.ImageUltimate.Web" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Overview</title>
    <link href="<%=ExamplesCoreConfiguration.GetVersionedUrl("~/resources/table.css")%>" rel="stylesheet" />
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
