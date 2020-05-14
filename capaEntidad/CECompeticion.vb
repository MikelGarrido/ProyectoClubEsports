Public Class CECompeticion

    Private _IDCOMPETICION As Integer
    Private _NOMBRE As String
    Private _FECHA As String
    Private _JUEGO As String

    Public Property IDCOMPETICION As Integer
        Get
            Return _IDCOMPETICION
        End Get
        Set(value As Integer)
            _IDCOMPETICION = value
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
    Public Property FECHA As String
        Get
            Return _FECHA
        End Get
        Set(value As String)
            _FECHA = value
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

End Class
