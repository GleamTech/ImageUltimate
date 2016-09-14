﻿Imports GleamTech.ExamplesCore
Imports GleamTech.ImageUltimate
Imports GleamTech.ImageUltimateExamples.Mvc.VB.Models

Namespace Controllers
    Partial Public Class HomeController
        Inherits Controller

        Function Overview() As ActionResult
            Dim model = New OverviewViewModel() With {
                .ExampleFileSelector = New ExampleFileSelector() With {
                    .ID = "exampleFileSelector",
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
                model.ImageData.Add("PixelFormat", imageInfo.PixelFormatInfo.Description)
                model.ImageData.Add("&#10551; ColorModel", imageInfo.PixelFormatInfo.ColorModel)
                model.ImageData.Add("&#10551; BitDepth", imageInfo.PixelFormatInfo.BitDepth)
                model.ImageData.Add("&#10551; HasAlpha", imageInfo.PixelFormatInfo.HasAlpha)
                model.ImageData.Add("&#10551; IsIndexed", imageInfo.PixelFormatInfo.IsIndexed)
                model.ImageData.Add("&#10551; IsRgb", imageInfo.PixelFormatInfo.IsRgb)
                model.ImageData.Add("&#10551; IsExtended", imageInfo.PixelFormatInfo.IsExtended)
                model.ImageData.Add("&#10551; ChannelCount", imageInfo.PixelFormatInfo.ChannelCount)
                model.ImageData.Add("&#10551; MaxChannelValue", imageInfo.PixelFormatInfo.MaxChannelValue)

                For Each entry In imageInfo.ExifDictionary
                    model.ImageExifMetadata.Add(entry.Key.ToString(), Tuple.Create(entry.ValueString, entry.Description))
                Next

                If model.ImageExifMetadata.Count = 0 Then
                    model.ImageExifMetadata.Add("", Tuple.Create("", ""))
                End If

                For Each entry In imageInfo.IptcDictionary
                    model.ImageIptcMetadata.Add(entry.Key.ToString(), Tuple.Create(entry.ValueString, entry.Description))
                Next

                If model.ImageIptcMetadata.Count = 0 Then
                    model.ImageIptcMetadata.Add("", Tuple.Create("", ""))
                End If
            End Using

            Return View(model)
        End Function
    End Class
End Namespace
