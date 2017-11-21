Imports GleamTech.Examples
Imports GleamTech.ImageUltimate.Web

Namespace Models

    Public Class ProcessingViewModel

        Public Property ExampleFileSelector As ExampleFileSelector

        Public Property TaskSelectList As SelectList

        Public Property ImagePath As String

        Public Property TaskAction As Action(Of ImageWebTask)

    End Class

End NameSpace