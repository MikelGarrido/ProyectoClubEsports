Imports capaDatos
Imports capaEntidad
Public Class CNJugador

    Dim objCapaDatos As New CDJugador
    Function listarJugadores() As DataSet
        Return objCapaDatos.listarJugadores
    End Function
    Function generarCodigoJugador() As Integer
        Return objCapaDatos.generarCodigoJugador
    End Function
    Sub registroJugadores(ByVal obj As CEJugador)
        objCapaDatos.registroJugadores(obj)
    End Sub
    Sub borrarJugadores(ByVal obj As CEJugador)
        objCapaDatos.borrarJugadores(obj)
    End Sub
    Sub modificarJugadores(ByVal obj As CEJugador)
        objCapaDatos.modificarJugadores(obj)
    End Sub

End Class
