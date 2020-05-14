Public Class CEAfiliado

    Private _IDAFILIADO As Integer
    Private _NOMBRE As String
    Private _FECHAAF As String
    Private _IDCLUB As String

    Public Property IDAFILIADO As Integer
        Get
            Return _IDAFILIADO
        End Get
        Set(value As Integer)
            _IDAFILIADO = value
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
    Public Property FECHAAF As String
        Get
            Return _FECHAAF
        End Get
        Set(value As String)
            _FECHAAF = value
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
