Imports capaEntidad
Imports capaNegocio
Public Class NuevaCompetir


    Dim objCompetir As New CECompetir
    Dim objNegocio As New CNCompetir

    Function getCodigoJugador() As Integer
        Return txtCodJugador.Text.Trim
    End Function
    Function getCodigoCompeticion() As Integer
        Return txtCompeticion.Text.Trim
    End Function

    Sub registroCompetir()
        objCompetir.IDJUGADOR = getCodigoJugador()
        objCompetir.IDCOMPETICION = getCodigoCompeticion()
        objNegocio.registroCompetir(objCompetir)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroCompetir()
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.Close()
    End Sub
End Class