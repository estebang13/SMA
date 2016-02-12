Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim db As DBClassesDataContext
        'db = New DBClassesDataContext()

        'Dim areas = From a In db.Areas Select a

        'For Each a In areas
        '    Dim message, title, defaultValue As String
        '    Dim myValue As Object
        '    ' Set prompt.
        '    message = "Enter a value between 1 and 3"
        '    ' Set title.
        '    title = "InputBox Demo"
        '    defaultValue = "1"   ' Set default value.

        '    ' Display message, title, and default value.
        '    myValue = InputBox("id= " + a.idArea.ToString() + " ,DES= " + a.descripcion.ToString(), title, defaultValue)
        'Next




        'Dim area As Areas
        'area = New Areas()



        'Dim m As String
        'm = Request.Form("nameArea")

        'area.descripcion = m

        'db.Areas.InsertOnSubmit(area)
        'db.SubmitChanges()

        'Dim message, title, defaultValue As String
        'Dim myValue As Object
        '' Set prompt.
        'message = "Enter a value between 1 and 3"
        '' Set title.
        'title = "InputBox Demo"
        'defaultValue = "1"   ' Set default value.

        '' Display message, title, and default value.
        'myValue = InputBox(areas.ToString(), title, defaultValue)
        ' If user has clicked Cancel, set myValue to defaultValue 
        'If myValue Is "" Then myValue = defaultValue

        ' Display dialog box at position 100, 100.
        'myValue = InputBox(message, title, defaultValue, 100, 100)
        ' If user has clicked Cancel, set myValue to defaultValue 
        'If myValue Is "" Then myValue = defaultValue
    End Sub

End Class