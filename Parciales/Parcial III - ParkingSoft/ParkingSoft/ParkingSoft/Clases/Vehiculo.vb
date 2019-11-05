Public Class Vehiculo
    Private _id As Integer
    Private _placa As String
    Private _propietario As String
    Private _tipo As String

    'Propiedades
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Placa() As Integer
        Get
            Return _placa
        End Get
        Set(ByVal value As Integer)
            _placa = value
        End Set
    End Property

    Public Property Propietario() As Integer
        Get
            Return _propietario
        End Get
        Set(ByVal value As Integer)
            _propietario = value
        End Set
    End Property

    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
        End Set
    End Property


End Class
