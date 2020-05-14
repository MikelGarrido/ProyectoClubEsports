Imports capaDatos
Imports capaEntidad
Public Class CNProyecto


    Dim objCapaDatos As New CDProyecto
    Function listarProyectos() As DataSet
        Return objCapaDatos.listarProyectos
    End Function
    Function generarCodigoProyecto() As Integer
        Return objCapaDatos.generarCodigoProyecto
    End Function
    Sub registroProyectos(ByVal obj As CEProyecto)
        objCapaDatos.registroProyectos(obj)
    End Sub
    Sub borrarProyectos(ByVal obj As CEProyecto)
        objCapaDatos.borrarProyectos(obj)
    End Sub
    Sub modificarProyectos(ByVal obj As CEProyecto)
        objCapaDatos.modificarProyectos(obj)
    End Sub


End Class
