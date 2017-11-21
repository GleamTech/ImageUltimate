Imports GleamTech.Examples
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
                model.ImageData.Add("⤷ ColorModel", imageInfo.PixelFormatInfo.ColorModel)
                model.ImageData.Add("⤷ BitDepth", imageInfo.PixelFormatInfo.BitDepth)
                model.ImageData.Add("⤷ HasAlpha", imageInfo.PixelFormatInfo.HasAlpha)
                model.ImageData.Add("⤷ IsIndexed", imageInfo.PixelFormatInfo.IsIndexed)
                model.ImageData.Add("⤷ IsRgb", imageInfo.PixelFormatInfo.IsRgb)
                model.ImageData.Add("⤷ IsExtended", imageInfo.PixelFormatInfo.IsExtended)
                model.ImageData.Add("⤷ ChannelCount", imageInfo.PixelFormatInfo.ChannelCount)
                model.ImageData.Add("⤷ MaxChannelValue", imageInfo.PixelFormatInfo.MaxChannelValue)

                For Each entry In imageInfo.ExifDictionary
                    model.ImageExifMetadata.Add(entry.Key.ToString(), Tuple.Create(GetStringValue(entry), entry.Description))
                Next

                If model.ImageExifMetadata.Count = 0 Then
                    model.ImageExifMetadata.Add("", Tuple.Create("", ""))
                End If

                For Each entry In imageInfo.IptcDictionary
                    model.ImageIptcMetadata.Add(entry.Key.ToString(), Tuple.Create(GetStringValue(entry), entry.Description))
                Next

                If model.ImageIptcMetadata.Count = 0 Then
                    model.ImageIptcMetadata.Add("", Tuple.Create("", ""))
                End If
            End Using

            Return View(model)
        End Function

        Private Shared Function GetStringValue(Of TKey)(entry As MetadataEntry(Of TKey)) As String
	        If TypeOf entry.Value Is String Then
		        Return entry.ValueString
	        End If

	        Dim valueType = entry.Value.GetType()
	        If valueType.IsArray Then
		        Return String.Format("{0} array with length {1}", valueType.GetElementType(), DirectCast(entry.Value, ICollection).Count)
	        End If

	        If entry.Values.Length > 1 Then
		        Return String.Format("{0} array with length {1}", entry.Values(0).GetType(), entry.Values.Length)
	        End If

	        Return entry.ValueString
        End Function

    End Class
End Namespace
