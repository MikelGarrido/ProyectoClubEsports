Imports capaDatos
Imports capaEntidad
Public Class CNCompetir

    Dim objCapaDatos As New CDCompetir
    Function listarCompetir() As DataSet
        Return objCapaDatos.listarCompetir
    End Function
    Sub registroCompetir(ByVal obj As CECompetir)
        objCapaDatos.registroCompetir(obj)
    End Sub

End Class