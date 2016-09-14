Imports GleamTech.ExamplesCore

Namespace Models

    Public Class OverviewViewModel
        Public Sub New()
            ImageData = New Dictionary(Of String, Object)()
            ImageExifMetadata = New Dictionary(Of String, Tuple(Of String, String))()
            ImageIptcMetadata = New Dictionary(Of String, Tuple(Of String, String))()
        End Sub

        Public Property ExampleFileSelector As ExampleFileSelector

        Public Property ImageData As Dictionary(Of String, Object)

        Public Property ImageExifMetadata As Dictionary(Of String, Tuple(Of String, String))

        Public Property ImageIptcMetadata As Dictionary(Of String, Tuple(Of String, String))

        Public Property ImagePath As String
    End Class

End NameSpace