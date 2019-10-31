Imports System.Drawing
Imports System.Linq.Expressions
Imports GleamTech.Examples
Imports GleamTech.ImageUltimate
Imports GleamTech.ImageUltimate.AspNet
Imports GleamTech.ImageUltimateExamples.AspNetMvcVB.Models
Imports GleamTech.Util

Namespace Controllers
    Partial Public Class HomeController
        Inherits Controller

        Private Shared ReadOnly TaskExpressions As Expression(Of Action(Of ImageWebTask))() = {
            Function(task) task.ResizeWidth(300, ResizeMode.Max), 
            Function(task) task.ResizeHeight(200, ResizeMode.Max), 
            Function(task) task.Resize(300, 300, ResizeMode.Max), 
            Function(task) task.ResizeWidth(50, ResizeMode.Percentage), 
            Function(task) task.Resize(50, 60, ResizeMode.Percentage), 
            Function(task) task.Resize(300, 300, ResizeMode.Stretch),
            Function(task) task.LiquidResize(75, 100, ResizeMode.Percentage), 
            Function(task) task.Crop(0, 0, 150, 150), 
            Function(task) task.TrimBorders(Color.Black, 10),
            Function(task) task.Rotate(45, Color.Transparent), 
            Function(task) task.Rotate(-45, Color.Transparent), 
            Function(task) task.FlipHorizontal(),
            Function(task) task.FlipVertical(), 
            Function(task) task.Brightness(20), 
            Function(task) task.Brightness(-20), 
            Function(task) task.Contrast(20), 
            Function(task) task.Contrast(-20),
            Function(task) task.BrightnessContrast(20, 20),
            Function(task) task.Enhance(), 
            Function(task) task.Blur(1),
            Function(task) task.Sharpen(1),
            Function(task) task.Format(ImageWebSafeFormat.Png), 
            Function(task) task.FileName("CustomNameForSEO")
        }

        Function Processing() As ActionResult
            Dim selectedValue As Integer
            Integer.TryParse(Request("taskSelector"), selectedValue)

            Dim model = New ProcessingViewModel() With {
                .ExampleFileSelector = New ExampleFileSelector() With {
                    .Id = "exampleFileSelector",
                    .InitialFile = "JPG Image.jpg",
                    .FormWrapped = False
                    },
                .TaskSelectList = PopulateTaskSelector(selectedValue)
            }

            model.ImagePath = model.ExampleFileSelector.SelectedFile

            Dim expression = TaskExpressions(selectedValue)
            Dim lambda = expression.Compile()

            model.TaskAction = Sub(task) 
                task.ResizeWidth(400)
                lambda(task)
            End Sub

            model.CodeString = String.Format(
                "@Me.ImageTag(""{0}"", {1})", 
                model.ExampleFileSelector.SelectedFile.FileName, 
                ExpressionStringBuilder.ToString(expression))

            Return View(model)
        End Function

        Private Function PopulateTaskSelector(selectedValue As Integer) As List(Of SelectListItem)
            Dim items = New List(Of SelectListItem)()

            Dim i = 0
            While i < TaskExpressions.Length
                items.Add(
                    New SelectListItem() With {
                        .Text = ExpressionStringBuilder.ToString(TaskExpressions(i)),
                        .Value = i.ToString(),
                        .Selected = (i = selectedValue)
                    }
                )
                i += 1
            End While

            Return items
        End Function

    End Class
End Namespace
