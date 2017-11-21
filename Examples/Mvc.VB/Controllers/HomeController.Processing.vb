Imports System.Drawing
Imports GleamTech.Examples
Imports GleamTech.ImageUltimate
Imports GleamTech.ImageUltimate.Web
Imports GleamTech.ImageUltimateExamples.Mvc.VB.Models

Namespace Controllers
    Partial Public Class HomeController
        Inherits Controller

        Function Processing() As ActionResult
            Dim model = New ProcessingViewModel() With {
                    .ExampleFileSelector = New ExampleFileSelector() With {
                    .ID = "exampleFileSelector",
                    .InitialFile = "JPG Image.jpg",
                    .FormWrapped = False
                    },
                    .TaskSelectList = PopulateTaskSelector(Request("taskSelector"))
                    }

            model.ImagePath = model.ExampleFileSelector.SelectedFile
            model.TaskAction = GetTaskAction(If(Request("taskSelector"), model.TaskSelectList.First().Text))

            Return View(model)
        End Function

        Private Function PopulateTaskSelector(selectedValue As String) As SelectList
            Return New SelectList(New SelectListItem() { 
                New SelectListItem() With { .Text = "ResizeWidth(300)" },
                New SelectListItem() With { .Text = "ResizeHeight(300)"},
                New SelectListItem() With { .Text = "Resize(300, 300)" },
                New SelectListItem() With { .Text = "Resize(300, 300, ResizeMode.Crop)" }, 
                New SelectListItem() With { .Text = "Resize(300, 300, ResizeMode.Stretch)" }, 
                New SelectListItem() With { .Text = "Crop(0, 0, 300, 300)" },
                New SelectListItem() With { .Text = "CropBorders(Color.Black, 10)" }, 
                New SelectListItem() With { .Text = "Rotate(45)" }, 
                New SelectListItem() With { .Text = "Rotate(-45)" }, 
                New SelectListItem() With { .Text = "Flip(FlipMode.Horizontal)" }, 
                New SelectListItem() With { .Text = "Flip(FlipMode.Vertical)" }, 
                New SelectListItem() With { .Text = "Brightness(20)" },
                New SelectListItem() With { .Text = "Brightness(-20)" },
                New SelectListItem() With { .Text = "BrightnessAuto()" },
                New SelectListItem() With { .Text = "Contrast(20)" },
                New SelectListItem() With { .Text = "Contrast(-20)" },
                New SelectListItem() With { .Text = "ContrastAuto()" },
                New SelectListItem() With { .Text = "BrightnessContrast(20, 20)" },
                New SelectListItem() With { .Text = "Format(ImageWebSaveFormat.Png)" },
                New SelectListItem() With { .Text = "FileName(""CustomNameForSEO"")" }
            }, "Text", "Text", selectedValue)
        End Function

        Private Function GetTaskAction(taskSelector As String) As Action(Of ImageWebTask)
            Select Case taskSelector
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
End Namespace
