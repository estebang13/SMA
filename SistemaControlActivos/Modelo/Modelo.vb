Public Class Modelo

    Private plantadao As PlantasDAO

    Public Sub New()
        Me.plantadao = New PlantasDAO
    End Sub

    Public Function getAllPlantas() As List(Of PlantasDTO)
        Return plantadao.getAllPlantas
    End Function

    Public Function insertarPlanta(descripcion As String, telefono As String) As Integer
        Return plantadao.insertarPlanta(descripcion, telefono)
    End Function

    Public Function modificarPlanta(idPlanta As Integer, telefono As String) As Integer
        Return plantadao.modificarPlanta(idPlanta, telefono)
    End Function

End Class
