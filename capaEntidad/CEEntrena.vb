Public Class CEEntrena

    Private _IDENTRENADOR As Integer
    Private _IDJUGADOR As Integer

    Public Property IDENTRENADOR As Integer
        Get
            Return _IDENTRENADOR
        End Get
        Set(value As Integer)
            _IDENTRENADOR = value
        End Set
    End Property

    Public Property IDJUGADOR As Integer
        Get
            Return _IDJUGADOR
        End Get
        Set(value As Integer)
            _IDJUGADOR = value
        End Set
    End Property

End Class
