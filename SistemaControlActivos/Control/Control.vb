Public Class Control

    Private modelo As Modelo

    Public Sub New()
        modelo = New Modelo
    End Sub

    Public Function getAllPlantas() As List(Of PlantasDTO)
        Return modelo.getAllPlantas
    End Function

End Class
