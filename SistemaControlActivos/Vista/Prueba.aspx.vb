Public Class Prueba
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim row As HtmlTableRow
        Dim cell As HtmlTableCell
        Dim btn As New Button
        Dim db As DBClassesDataContext = New DBClassesDataContext

        For Each a In db.Plantas

            row = New HtmlTableRow

            cell = New HtmlTableCell
            cell.InnerHtml = a.idPlanta.ToString
            row.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = a.Descripcion
            row.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = a.Telefono
            row.Cells.Add(cell)

            cell = New HtmlTableCell
            btn = New Button
            btn.ID = a.idPlanta.ToString() + "M"
            btn.CssClass = "btn btn-info"
            btn.Text = "Modificar"
            AddHandler btn.Click, AddressOf modificarPlanta
            cell.Controls.Add(btn)
            row.Cells.Add(cell)


            cell = New HtmlTableCell
            cell.InnerHtml = "<input type='button' id='" + a.idPlanta.ToString() + "' class='btn btn-primary' data-toggle='modal' data-target='#exampleModal' data-whatever='@mdo' value='Open modal for @mdo' />"
            row.Cells.Add(cell)

            table1.Rows.Add(row)
        Next
    End Sub

    Private Sub modificarPlanta(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim message, title, defaultValue As String
        Dim myValue As Object
        ' Set prompt.
        message = "Enter a value between 1 and 3"
        ' Set title.
        title = "Modificar"
        defaultValue = "1"   ' Set default value.

        ' Display message, title, and default value.
        myValue = InputBox("id= " + btn.ID.Replace("M", ""), title, defaultValue)
    End Sub

End Class