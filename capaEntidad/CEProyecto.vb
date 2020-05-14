Public Class CEProyecto

    Private _IDPROYECTO As Integer
    Private _DESCRIPCION As String
    Private _IDCLUB As String

    Public Property IDPROYECTO As Integer
        Get
            Return _IDPROYECTO
        End Get
        Set(value As Integer)
            _IDPROYECTO = value
        End Set
    End Property
    Public Property DESCRIPCION As String
        Get
            Return _DESCRIPCION
        End Get
        Set(value As String)
            _DESCRIPCION = value
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
