<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Processing.aspx.cs" Inherits="GleamTech.ImageUltimateExamples.WebForms.CS.ProcessingPage" %>
<%@ Register TagPrefix="GleamTech" Namespace="GleamTech.Examples" Assembly="GleamTech.Core" %>
<%@ Import Namespace="GleamTech.ImageUltimate.AspNet.WebForms" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Image Processing</title>
    <asp:PlaceHolder runat="server">
        <link href="<%=ExamplesConfiguration.GetVersionedUrl("~/resources/table.css")%>" rel="stylesheet" />
    </asp:PlaceHolder>
</head>
<body style="margin: 20px;">
    
    <form id="form1" runat="server">
        <GleamTech:ExampleFileSelectorControl ID="exampleFileSelector" runat="server"
            InitialFile="JPG Image.jpg"
            FormWrapped="False" />

        <p>
            Choose task: <asp:DropDownList ID="TaskSelector" runat="server" AutoPostBack="true"></asp:DropDownList>
        </p>
    </form>

    <table class="info image">
        <caption>Resulting Image</caption>
        <tr>
            <td><%=this.ImageTag(ImagePath, TaskAction)%></td>
        </tr>
    </table>

    <table class="info image">
        <caption>Original Image (Resized to width 300)</caption>
        <tr>
            <td><%=this.ImageTag(ImagePath, task => task.ResizeWidth(300))%></td>
        </tr>
    </table>
    
    <table class="info">
        <caption>Resulting Image Url</caption>
        <tr>
            <td><%=this.ImageUrl(ImagePath, TaskAction)%></td>
        </tr>
    </table>

</body>
</html>
