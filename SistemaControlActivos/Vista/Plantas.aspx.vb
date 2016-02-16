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
            cell.InnerHtml = "<input type='button' class='btn btn-info' data-toggle='modal' data-target='#ModalModificar' data-whatever='modificar," + a.IdValue.ToString() + "," + a.DescripcionValue() + "," + a.TelefonoValue() + "' value='Modificar' />"
            row.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<input type='button' class='btn btn-danger' data-toggle='modal' data-target='#ModalEliminar' data-whatever='" + a.IdValue.ToString() + "," + a.DescripcionValue + "' value='Eliminar' />"
            row.Cells.Add(cell)

            table1.Rows.Add(row)
        Next

    End Sub

    Public Sub insertarPlanta(ByVal sender As Object, ByVal e As EventArgs)
        Dim nombrePlanta As String = Request.Form("nombrePlanta")
        Dim telefonoPlanta As String = Request.Form("telefonoPlanta")
        If (Not IsNothing(nombrePlanta)) And (Not IsNothing(telefonoPlanta)) Then
            Dim valor As Integer = control.insertarPlanta(nombrePlanta, telefonoPlanta)
            Response.Redirect(Request.Url.AbsoluteUri)
            ClientScript.RegisterClientScriptBlock(Me.GetType, "alert", "alert('Planta insertada correctamente.')", True)
        Else
            ClientScript.RegisterClientScriptBlock(Me.GetType, "alert", "alert('Debe de completar los espacios.')", True)
        End If

    End Sub

    Public Sub modificarPlanta(ByVal sender As Object, ByVal e As EventArgs)
        Dim idPlanta As String = Request.Form("idPlanta")
        Dim telefonoPlanta As String = Request.Form("telefonoPlanta")
        If (Not IsNothing(telefonoPlanta)) Then
            'modificar en la base de datos
            control.modificarPlanta(Integer.Parse(idPlanta), telefonoPlanta)
            Response.Redirect(Request.Url.AbsoluteUri)
            ClientScript.RegisterClientScriptBlock(Me.GetType, "alert", "alert('Cambios realizados correctamente.')", True)
        Else
            ClientScript.RegisterClientScriptBlock(Me.GetType, "alert", "alert('Debe de completar el telefono.')", True)
        End If
    End Sub

    Public Sub eliminarPlanta(ByVal sender As Object, ByVal e As EventArgs)
        Dim idPlanta As String = Request.Form("idPlantaEliminar")
        control.eliminarPlanta(Integer.Parse(idPlanta))
        ClientScript.RegisterClientScriptBlock(Me.GetType, "alert", "alert('Cambios realizados correctamente. " + idPlanta + "')", True)
        Response.Redirect(Request.Url.AbsoluteUri)
    End Sub

End Class