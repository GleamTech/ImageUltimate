Imports GleamTech.Examples
Imports GleamTech.ImageUltimate.AspNet

Namespace Models

    Public Class ProcessingViewModel

        Public Property ExampleFileSelector As ExampleFileSelector

        Public Property TaskSelectList As List(Of SelectListItem)

        Public Property ImagePath As String

        Public Property TaskAction As Action(Of ImageWebTask)

        Public Property CodeString As String

    End Class

End NameSpace