Imports GleamTech.ImageUltimate

Public Class OverviewPage
    Inherits System.Web.UI.Page

	Protected ImagePath As String
	Protected ImageData As New Dictionary(Of String, Object)()
	Protected ImageExifMetadata As New Dictionary(Of String, Tuple(Of String, String))()
	Protected ImageIptcMetadata As New Dictionary(Of String, Tuple(Of String, String))()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		ImagePath = exampleFileSelector.SelectedFile

		Using imageInfo = New ImageInfo(ImagePath)
			ImageData.Add("Format", imageInfo.Format)
			ImageData.Add("Width", imageInfo.Width)
			ImageData.Add("Height", imageInfo.Height)
			ImageData.Add("DpiX", imageInfo.DpiX)
			ImageData.Add("DpiY", imageInfo.DpiY)
			ImageData.Add("PixelFormat", imageInfo.PixelFormatInfo.Description)
			ImageData.Add("⤷ ColorModel", imageInfo.PixelFormatInfo.ColorModel)
			ImageData.Add("⤷ BitDepth", imageInfo.PixelFormatInfo.BitDepth)
			ImageData.Add("⤷ HasAlpha", imageInfo.PixelFormatInfo.HasAlpha)
			ImageData.Add("⤷ IsIndexed", imageInfo.PixelFormatInfo.IsIndexed)
			ImageData.Add("⤷ IsRgb", imageInfo.PixelFormatInfo.IsRgb)
			ImageData.Add("⤷ IsExtended", imageInfo.PixelFormatInfo.IsExtended)
			ImageData.Add("⤷ ChannelCount", imageInfo.PixelFormatInfo.ChannelCount)
			ImageData.Add("⤷ MaxChannelValue", imageInfo.PixelFormatInfo.MaxChannelValue)

			For Each entry In imageInfo.ExifDictionary
				ImageExifMetadata.Add(entry.Key.ToString(), Tuple.Create(GetStringValue(entry), entry.Description))
			Next

			If ImageExifMetadata.Count = 0 Then
				ImageExifMetadata.Add("", Tuple.Create("", ""))
			End If

			For Each entry In imageInfo.IptcDictionary
				ImageIptcMetadata.Add(entry.Key.ToString(), Tuple.Create(GetStringValue(entry), entry.Description))
			Next

			If ImageIptcMetadata.Count = 0 Then
				ImageIptcMetadata.Add("", Tuple.Create("", ""))
			End If
		End Using
    End Sub

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