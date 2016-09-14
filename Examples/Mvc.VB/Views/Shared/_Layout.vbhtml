<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>
    @If (IsSectionDefined("ImageUltimateCss")) Then
        @RenderSection("ImageUltimateCss")
    End If
    @If (IsSectionDefined("ImageUltimateJs")) Then
        @RenderSection("ImageUltimateJs")
    End If
</head>
<body style="margin: 20px;">
    @RenderBody()
</body>
</html>
