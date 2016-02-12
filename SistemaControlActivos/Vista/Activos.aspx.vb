Public Class Activos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub modificarPlanta(ByVal sender As Object, ByVal e As EventArgs)
        'Dim btn As Button = DirectCast(sender, Button)
        Dim message, title, defaultValue As String
        Dim myValue As Object
        ' Set prompt.
        message = "Enter a value between 1 and 3"
        ' Set title.
        title = "Modificar"
        defaultValue = "1"   ' Set default value.

        ' Display message, title, and default value.
        myValue = InputBox("id", title, defaultValue)
    End Sub

End Class