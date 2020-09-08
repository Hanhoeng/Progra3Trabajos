Public Class TenisBase
    Private _Modelo As String
    Private _Talla As Double
    Private _Color As String
    Private _Precio As Double
    Private _Material As String

    Public Property Modelo As String
        Get
            Return _Modelo
        End Get
        Set
            _Modelo = Value
        End Set
    End Property

    Public Property Talla As Double
        Get
            Return _Talla
        End Get
        Set
            _Talla = Value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _Color
        End Get
        Set
            _Color = Value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _Precio
        End Get
        Set
            _Precio = Value
        End Set
    End Property

    Public Property Material As String
        Get
            Return _Material
        End Get
        Set
            _Material = Value
        End Set
    End Property
End Class
