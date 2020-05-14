Public Class CEJugador

    Private _IDJUGADOR As Integer
    Private _NOMBRE As String
    Private _SALARIO As Integer

    Public Property IDJUGADOR As Integer
        Get
            Return _IDJUGADOR
        End Get
        Set(value As Integer)
            _IDJUGADOR = value
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
    Public Property SALARIO As Integer
        Get
            Return _SALARIO
        End Get
        Set(value As Integer)
            _SALARIO = value
        End Set
    End Property



End Class
