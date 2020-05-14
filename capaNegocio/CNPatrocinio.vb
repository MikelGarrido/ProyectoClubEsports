Imports capaDatos
Imports capaEntidad
Public Class CNPatrocinio

    Dim objCapaDatos As New CDPatrocinio
    Function listarPatrocinios() As DataSet
        Return objCapaDatos.listarPatrocinios
    End Function
    Function generarCodigoPatrocinio() As Integer
        Return objCapaDatos.generarCodigoPatrocinio
    End Function
    Sub registroPatrocinios(ByVal obj As CEPatrocinio)
        objCapaDatos.registroPatrocinios(obj)
    End Sub
    Sub borrarPatrocinios(ByVal obj As CEPatrocinio)
        objCapaDatos.borrarPatrocinios(obj)
    End Sub
    Sub modificarPatrocinios(ByVal obj As CEPatrocinio)
        objCapaDatos.modificarPatrocinios(obj)
    End Sub


End Class
