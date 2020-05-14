Imports capaDatos
Imports capaEntidad
Public Class CNTrofeo

    Dim objCapaDatos As New CDTrofeo
    Function listarTrofeos() As DataSet
        Return objCapaDatos.listarTrofeos
    End Function
    Function generarCodigoTrofeo() As Integer
        Return objCapaDatos.generarCodigoTrofeo
    End Function
    Sub registroTrofeos(ByVal obj As CETrofeo)
        objCapaDatos.registroTrofeos(obj)
    End Sub
    Sub modificarTrofeos(ByVal obj As CETrofeo)
        objCapaDatos.modificarTrofeos(obj)
    End Sub


End Class
