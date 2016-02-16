Public Class Prueba
    Inherits System.Web.UI.Page

    Private control As Control

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        control = New Control

        Dim row As HtmlTableRow
        Dim cell As HtmlTableCell
        Dim btn As New Button

        Dim lista As List(Of PlantasDTO) = control.getAllPlantas

        For Each a In lista

            row = New HtmlTableRow

            cell = New HtmlTableCell
            cell.InnerHtml = a.IdValue.ToString
            row.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = a.DescripcionValue
            row.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = a.TelefonoValue
            row.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<input type='button' class='btn btn-primary' data-toggle='modal' data-target='#Modal' data-whatever='" + a.IdValue.ToString() + "," + a.DescripcionValue() + "," + a.TelefonoValue() + "' value='Modificar' />"
            row.Cells.Add(cell)

            table1.Rows.Add(row)
        Next
    End Sub

    Public Sub modificarPlanta(ByVal sender As Object, ByVal e As EventArgs)
        'Dim btn As HtmlButton = DirectCast(sender, HtmlButton)
        'Dim message, title, defaultValue As String
        'Dim myValue As Object
        '' Set prompt.
        'message = "Enter a value between 1 and 3"
        '' Set title.
        'title = "Modificar"
        'defaultValue = "1"   ' Set default value.

        '' Display message, title, and default value.
        'myValue = InputBox("id= " + btn.ID, title, defaultValue)
        'MsgBox("Success")
        ClientScript.RegisterClientScriptBlock(Me.GetType, "alert", "alert('Database updated.')", True)
    End Sub

End Class