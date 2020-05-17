Imports capaDatos
Imports capaEntidad
Public Class CNEntrenador



    Dim objCapaDatos As New CDEntrenador
    Function listarEntrenadores() As DataSet
        Return objCapaDatos.listarEntrenadores
    End Function
    Function generarCodigoEntrenador() As Integer
        Return objCapaDatos.generarCodigoEntrenador
    End Function
    Sub registroEntrenadores(ByVal obj As CEEntrenador)
        objCapaDatos.registroEntrenadores(obj)
    End Sub
    Sub modificarEntrenadores(ByVal obj As CEEntrenador)
        objCapaDatos.modificarEntrenadores(obj)
    End Sub


End Class
