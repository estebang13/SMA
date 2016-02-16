Public Class Control

    Private modelo As Modelo

    Public Sub New()
        modelo = New Modelo
    End Sub

    Public Function getAllPlantas() As List(Of PlantasDTO)
        Return modelo.getAllPlantas
    End Function

    Public Function insertarPlanta(descripcion As String, telefono As String) As Integer
        Return modelo.insertarPlanta(descripcion, telefono)
    End Function

    Public Function modificarPlanta(idPlanta As Integer, telefono As String) As Integer
        Return modelo.modificarPlanta(idPlanta, telefono)
    End Function

    Public Function eliminarPlanta(idPlanta As Integer) As Integer
        Return modelo.eliminarPlanta(idPlanta)
    End Function

End Class
