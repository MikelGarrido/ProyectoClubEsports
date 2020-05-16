Imports capaDatos
Imports capaEntidad
Public Class CNEntrena

    Dim objCapaDatos As New CDEntrena
    Function listarEntrenamientos() As DataSet
        Return objCapaDatos.listarEntrenamientos
    End Function
    Sub registroEntrenamientos(ByVal obj As CEEntrena)
        objCapaDatos.registroEntrenamiento(obj)
    End Sub
    Sub borrarEntrenamientos(ByVal obj As CEEntrena)
        objCapaDatos.borrarEntrenamiento(obj)
    End Sub
End Class
