Imports System.Data.SqlClient
Public Class PlantasDAO
    Inherits DAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(url As String)
        MyBase.New(url)
    End Sub

    Public Function getAllPlantas() As List(Of PlantasDTO)
        Dim lista As New List(Of PlantasDTO)()
        conectar()
        sql = "SELECT *FROM Plantas"
        comando = New SqlCommand(sql, conexion)
        reader = comando.ExecuteReader()
        lista = readReader(reader)
        desconectar()
        Return lista
    End Function


    Public Function readReader(reader As SqlDataReader) As List(Of PlantasDTO)
        Dim list As New List(Of PlantasDTO)()
        While reader.Read()
            list.Add(New PlantasDTO(reader.GetInt16(0), reader.GetString(1), reader.GetString(2)))
        End While
        Return list
    End Function
End Class
