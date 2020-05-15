Imports capaEntidad
Imports capaNegocio
Public Class BorradoJugador

    Dim objJugador As New CEJugador
    Dim objNegocio As New CNJugador
    Function getCodigo() As Integer
            Return txtCodigo.Text
        End Function
    Sub borrarJugador()
        objJugador.IDJUGADOR = getCodigo()
        objNegocio.borrarJugadores(objJugador)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        borrarJugador()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class