Imports capaDatos
Imports capaEntidad
Public Class CNAfiliado

    Dim objCapaDatos As New CDAfiliado
    Function listarAfiliados() As DataSet
        Return objCapaDatos.listarAfiliados
    End Function
    Function generarCodigoAfiliado() As Integer
        Return objCapaDatos.generarCodigoAfiliado
    End Function
    Sub registroAfiliados(ByVal obj As CEAfiliado)
        objCapaDatos.registroAfiliados(obj)
    End Sub
    Sub borrarAfiliados(ByVal obj As CEAfiliado)
        objCapaDatos.borrarAfiliados(obj)
    End Sub
    Sub modificarAfiliados(ByVal obj As CEAfiliado)
        objCapaDatos.modificarAfiliados(obj)
    End Sub

End Class
