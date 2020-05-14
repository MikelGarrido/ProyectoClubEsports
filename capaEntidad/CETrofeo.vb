Public Class CETrofeo

    Private _IDTROFEO As Integer
    Private _NOMBRE As String
    Private _JUEGO As String
    Private _IDCLUB As String

    Public Property IDTROFEO As Integer
        Get
            Return _IDTROFEO
        End Get
        Set(value As Integer)
            _IDTROFEO = value
        End Set
    End Property
    Public Property NOMBRE As String
        Get
            Return _NOMBRE
        End Get
        Set(value As String)
            _NOMBRE = value
        End Set
    End Property
    Public Property JUEGO As String
        Get
            Return _JUEGO
        End Get
        Set(value As String)
            _JUEGO = value
        End Set
    End Property

    Public Property IDCLUB As String
        Get
            Return _IDCLUB
        End Get
        Set(value As String)
            _IDCLUB = value
        End Set
    End Property





End Class
