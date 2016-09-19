Imports System.Drawing
Imports GleamTech.ImageUltimate
Imports GleamTech.ImageUltimate.Web

Public Class ProcessingPage
    Inherits System.Web.UI.Page

    Protected ImagePath As String
    Protected TaskAction As Action(Of ImageWebTask)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ImagePath = exampleFileSelector.SelectedFile

        If Not IsPostBack Then
            PopulateTaskSelector()
        End If

        TaskAction = GetTaskAction()
    End Sub

    Private Sub PopulateTaskSelector()
        TaskSelector.Items.AddRange(New ListItem() {
            New ListItem("ResizeWidth(300)"), 
            New ListItem("ResizeHeight(300)"),
            New ListItem("Resize(300, 300)"),
            New ListItem("Resize(300, 300, ResizeMode.Crop)"),
            New ListItem("Resize(300, 300, ResizeMode.Stretch)"),
            New ListItem("Crop(0, 0, 300, 300)"),
            New ListItem("CropBorders(Color.Black, 10)"), 
            New ListItem("Rotate(45)"),
            New ListItem("Rotate(-45)"), 
            New ListItem("Flip(FlipMode.Horizontal)"),
            New ListItem("Flip(FlipMode.Vertical)"), 
            New ListItem("Brightness(20)"),
            New ListItem("Brightness(-20)"), 
            New ListItem("BrightnessAuto()"),
            New ListItem("Contrast(20)"), 
            New ListItem("Contrast(-20)"),
            New ListItem("ContrastAuto()"), 
            New ListItem("BrightnessContrast(20, 20)"),
            New ListItem("Format(ImageWebSaveFormat.Png)"),
            New ListItem("FileName(""CustomNameForSEO"")")
        })
    End Sub

    Private Function GetTaskAction() As Action(Of ImageWebTask)
        Select Case TaskSelector.SelectedValue
            Case "ResizeWidth(300)"
                Return Function(task) task.ResizeWidth(300)
            Case "ResizeHeight(300)"
                Return Function(task) task.ResizeHeight(300)
            Case "Resize(300, 300)"
                Return Function(task) task.Resize(300, 300)
            Case "Resize(300, 300, ResizeMode.Crop)"
                Return Function(task) task.Resize(300, 300, ResizeMode.Crop)
            Case "Resize(300, 300, ResizeMode.Stretch)"
                Return Function(task) task.Resize(300, 300, ResizeMode.Stretch)
            Case "Crop(0, 0, 300, 300)"
                Return Function(task) task.Crop(0, 0, 300, 300)
            Case "CropBorders(Color.Black, 10)"
                Return Function(task) task.ResizeWidth(300).CropBorders(Color.Black, 10)
            Case "Rotate(45)"
                Return Function(task) task.ResizeWidth(300).Rotate(45)
            Case "Rotate(-45)"
                Return Function(task) task.ResizeWidth(300).Rotate(- 45)
            Case "Flip(FlipMode.Horizontal)"
                Return Function(task) task.ResizeWidth(300).Flip(FlipMode.Horizontal)
            Case "Flip(FlipMode.Vertical)"
                Return Function(task) task.ResizeWidth(300).Flip(FlipMode.Vertical)
            Case "Brightness(20)"
                Return Function(task) task.ResizeWidth(300).Brightness(20)
            Case "Brightness(-20)"
                Return Function(task) task.ResizeWidth(300).Brightness(- 20)
            Case "BrightnessAuto()"
                Return Function(task) task.ResizeWidth(300).BrightnessAuto()
            Case "Contrast(20)"
                Return Function(task) task.ResizeWidth(300).Contrast(20)
            Case "Contrast(-20)"
                Return Function(task) task.ResizeWidth(300).Contrast(- 20)
            Case "ContrastAuto()"
                Return Function(task) task.ResizeWidth(300).ContrastAuto()
            Case "BrightnessContrast(20, 20)"
                Return Function(task) task.ResizeWidth(300).BrightnessContrast(20, 20)
            Case "Format(ImageWebSaveFormat.Png)"
                Return Function(task) task.ResizeWidth(300).Format(ImageWebSaveFormat.Png)
            Case "FileName(""CustomNameForSEO"")"
                Return Function(task) task.ResizeWidth(300).FileName("CustomNameForSEO")
            Case Else
                Return Nothing
        End Select
    End Function
End Class