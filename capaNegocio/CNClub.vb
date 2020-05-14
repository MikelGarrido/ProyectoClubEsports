Imports capaDatos
Imports capaEntidad
Public Class CNClub
    Dim objCapaDatos As New CDClub
    Function listarClubes() As DataSet
        Return objCapaDatos.listarClubes
    End Function
    Sub registroClubes(ByVal obj As CEClub)
        objCapaDatos.registroClubes(obj)
    End Sub
    Sub borrarClubes(ByVal obj As CEClub)
        objCapaDatos.borrarClubes(obj)
    End Sub
    Sub modificarClubes(ByVal obj As CEClub)
        objCapaDatos.modificarClubes(obj)
    End Sub
End Class
