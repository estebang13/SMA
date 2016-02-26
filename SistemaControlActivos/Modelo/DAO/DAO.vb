Imports System.Data.SqlClient

Public Class DAO

    Public conexion As SqlConnection
    Public comando As SqlCommand
    Public reader As SqlDataReader
    Public sql As String
    Public DEFAULT_URL As String = "Initial Catalog=PLANTAS;Data Source=BRAYAN\SQLEXPRESS;Integrated Security=SSPI;"
    ' Dos cosas...
    ' La primera: Probando desde Visual Studio - desde el branch
    ' La segunda: Bryan cuando pueda explíqueme esta conexión a base de datos, para ver si es lo que estoy estendiendo o estoy mamerto...
    Public url As String


    Public Sub New()
        Me.url = Me.DEFAULT_URL
    End Sub
    Public Sub New(url As String)
        Me.url = url
    End Sub

    Public Sub conectar()
        Try
            conexion = New SqlConnection(url)
            conexion.Open()
        Catch ex As Exception
            MsgBox("Fallo al abrir conexion")
        End Try
    End Sub

    Public Sub desconectar()
        Try
            reader.Close()
            comando.Dispose()
            conexion.Close()
        Catch ex As Exception

        End Try

    End Sub


End Class
