Public Class CEPatrocinio

    Private _IDPATROCINIO As Integer
    Private _NOMBRE As String
    Private _PAGO As Integer
    Private _IDCLUB As String

    Public Property IDPATROCINIO As Integer
        Get
            Return _IDPATROCINIO
        End Get
        Set(value As Integer)
            _IDPATROCINIO = value
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
    Public Property PAGO As Integer
        Get
            Return _PAGO
        End Get
        Set(value As Integer)
            _PAGO = value
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
