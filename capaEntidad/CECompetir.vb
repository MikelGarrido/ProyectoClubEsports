Public Class CECompetir

    Private _IDJUGADOR As Integer
    Private _IDCOMPETICION As Integer

    Public Property IDJUGADOR As Integer
        Get
            Return _IDJUGADOR
        End Get
        Set(value As Integer)
            _IDJUGADOR = value
        End Set
    End Property

    Public Property IDCOMPETICION As Integer
        Get
            Return _IDCOMPETICION
        End Get
        Set(value As Integer)
            _IDCOMPETICION = value
        End Set
    End Property

End Class
