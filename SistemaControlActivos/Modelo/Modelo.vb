Public Class Modelo

    Private plantadao As PlantasDAO

    Public Sub New()
        Me.plantadao = New PlantasDAO
    End Sub

    Public Function getAllPlantas() As List(Of PlantasDTO)
        Return plantadao.getAllPlantas
    End Function

End Class
