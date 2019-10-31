Imports GleamTech.Examples
Imports GleamTech.ImageUltimate
Imports GleamTech.ImageUltimateExamples.AspNetMvcVB.Models

Namespace Controllers
    Partial Public Class HomeController
        Inherits Controller

        Function Overview() As ActionResult
            Dim model = New OverviewViewModel() With {
                .ExampleFileSelector = New ExampleFileSelector() With {
                    .Id = "exampleFileSelector",
                    .InitialFile = "JPG Image.jpg"
                }
            }

            model.ImagePath = model.ExampleFileSelector.SelectedFile

            Using imageInfo = New ImageInfo(model.ImagePath)
                model.ImageData.Add("Format", imageInfo.Format)
                model.ImageData.Add("Width", imageInfo.Width)
                model.ImageData.Add("Height", imageInfo.Height)
                model.ImageData.Add("DpiX", imageInfo.DpiX)
                model.ImageData.Add("DpiY", imageInfo.DpiY)
                model.ImageData.Add("ColorSpace", imageInfo.ColorSpace)
                model.ImageData.Add("ColorType", imageInfo.ColorType)
                model.ImageData.Add("BitDepth", imageInfo.BitDepth)
                model.ImageData.Add("HasAlpha", imageInfo.HasAlpha)
                model.ImageData.Add("ChannelCount", imageInfo.ChannelCount)

                For Each entry In imageInfo.ExifDictionary
                    model.ImageExifMetadata.Add(entry.Tag.ToString(), Tuple.Create(entry.Value, entry.Description))
                Next

                If model.ImageExifMetadata.Count = 0 Then
                    model.ImageExifMetadata.Add("", Tuple.Create("", ""))
                End If

                For Each entry In imageInfo.IptcDictionary
                    model. ImageIptcMetadata.Add(entry.Tag.ToString(), Tuple.Create(entry.Value, entry.Description))
                Next

                If model.ImageIptcMetadata.Count = 0 Then
                    model.ImageIptcMetadata.Add("", Tuple.Create("", ""))
                End If
            End Using

            Return View(model)
        End Function

    End Class
End Namespace
