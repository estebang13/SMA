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
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "seleccionarTodasPlantas"
        comando.CommandType = CommandType.StoredProcedure
        reader = comando.ExecuteReader()
        lista = readReader(reader)
        desconectar()
        Return lista
    End Function

    Public Function insertarPlanta(descripcion As String, telefono As String) As Integer
        Dim valor As Integer = 0
        conectar()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "insertarPlanta"
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("Descripcion", descripcion)
        comando.Parameters.AddWithValue("Telefono", telefono)

        valor = comando.ExecuteNonQuery()

        desconectar()
        Return valor
    End Function

    Public Function modificarPlanta(idPlanta As Integer, telefono As String) As Integer
        Dim valor As Integer = 0
        conectar()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "actualizarPlanta"
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("Id", idPlanta)
        comando.Parameters.AddWithValue("Telefono", telefono)

        valor = comando.ExecuteNonQuery()

        desconectar()
        Return valor
    End Function

    Public Function eliminarPlanta(idPlanta As Integer) As Integer
        Dim valor As Integer = 0
        conectar()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "eliminarPlanta"
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("Id", idPlanta)

        valor = comando.ExecuteNonQuery()

        desconectar()
        Return valor
    End Function

    Public Function readReader(reader As SqlDataReader) As List(Of PlantasDTO)
        Dim list As New List(Of PlantasDTO)()
        While reader.Read()
            list.Add(New PlantasDTO(Integer.Parse(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2)))
        End While
        Return list
    End Function
End Class
