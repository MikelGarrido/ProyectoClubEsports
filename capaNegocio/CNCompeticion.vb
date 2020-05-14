Imports capaDatos
Imports capaEntidad
Public Class CNCompeticion

    Dim objCapaDatos As New CDCompeticion
    Function listarCompeticiones() As DataSet
        Return objCapaDatos.listarCompeticiones
    End Function
    Function generarCodigoCompeticion() As Integer
        Return objCapaDatos.generarCodigoCompeticion
    End Function
    Sub registroCompeticiones(ByVal obj As CECompeticion)
        objCapaDatos.registroCompeticiones(obj)
    End Sub
    Sub modificarCompeticiones(ByVal obj As CECompeticion)
        objCapaDatos.modificarCompeticiones(obj)
    End Sub

End Class
