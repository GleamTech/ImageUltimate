<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>
    @If (IsSectionDefined("ImageUltimateHead")) Then
        @RenderSection("ImageUltimateHead")
    End If
</head>
<body style="margin: 20px;">
    @RenderBody()
</body>
</html>
