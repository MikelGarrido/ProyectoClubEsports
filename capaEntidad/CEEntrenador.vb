Public Class CEEntrenador

    Private _IDENTRENADOR As Integer
    Private _NOMBRE As String
    Private _SALARIO As Integer
    Private _IDCLUB As String

    Public Property IDENTRENADOR As Integer
        Get
            Return _IDENTRENADOR
        End Get
        Set(value As Integer)
            _IDENTRENADOR = value
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

    Public Property IDCLUB As String
        Get
            Return _IDCLUB
        End Get
        Set(value As String)
            _IDCLUB = value
        End Set
    End Property

End Class
