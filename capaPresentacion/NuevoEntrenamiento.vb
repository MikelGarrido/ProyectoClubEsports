Imports capaEntidad
Imports capaNegocio
Public Class NuevoEntrenamiento


    Dim objEntrenamiento As New CEEntrena
    Dim objNegocio As New CNEntrena
    Function getCodigoEntrenador() As Integer
        Return txtCodEntrenador.Text.Trim
    End Function
    Function getCodigoJugador() As Integer
        Return txtCodJugador.Text.Trim
    End Function


    Sub registroEntrenamientos()
        objEntrenamiento.IDENTRENADOR = getCodigoEntrenador()
        objEntrenamiento.IDJUGADOR = getCodigoJugador()
        objNegocio.registroEntrenamientos(objEntrenamiento)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroEntrenamientos()
    End Sub

End Class