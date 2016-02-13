Public Class Plantas1
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
            btn = New Button
            btn.ID = a.IdValue.ToString() + "M"
            btn.CssClass = "btn btn-info"
            btn.Text = "Modificar"
            AddHandler btn.Click, AddressOf modificarPlanta
            cell.Controls.Add(btn)
            row.Cells.Add(cell)

            cell = New HtmlTableCell
            btn = New Button
            btn.ID = a.IdValue.ToString() + "E"
            btn.CssClass = "btn btn-danger"
            btn.Text = "Eliminar"
            AddHandler btn.Click, AddressOf eliminarPlanta
            cell.Controls.Add(btn)
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

    Private Sub eliminarPlanta(ByVal sender As Object, ByVal e As EventArgs)
        'Dim btn As Button = DirectCast(sender, Button)
        'Dim message, title, defaultValue As String
        'Dim myValue As Object
        ' Set prompt.
        'message = "Enter a value between 1 and 3"
        ' Set title.
        'title = "Eliminar"
        'defaultValue = "1"   ' Set default value.

        ' Display message, title, and default value.
        'myValue = InputBox("id= " + btn.ID.Replace("E", ""), title, defaultValue)
    End Sub

End Class