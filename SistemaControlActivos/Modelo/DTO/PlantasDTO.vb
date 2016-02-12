Public Class PlantasDTO

    Public id As Integer
    Private descripcion As String
    Private telefono As String

    Public Sub New(id As Integer, descripcion As String, telefono As String)
        Me.id = id
        Me.descripcion = descripcion
        Me.telefono = telefono
    End Sub

    Public Property IdValue() As Integer
        Get
            Return Me.id
        End Get
        Set(value As Integer)
            Me.id = value
        End Set
    End Property

    Public Property DescripcionValue() As String
        Get
            Return Me.descripcion
        End Get
        Set(value As String)
            Me.descripcion = value
        End Set
    End Property

    Public Property TelefonoValue() As String
        Get
            Return Me.telefono
        End Get
        Set(value As String)
            Me.telefono = value
        End Set
    End Property

End Class
