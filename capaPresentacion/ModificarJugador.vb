Imports capaEntidad
Imports capaNegocio
Public Class ModificarJugador

    Dim objJugador As New CEJugador
    Dim objNegocio As New CNJugador
    Function getCodigo() As Integer
        Return txtCodigo.Text.Trim
    End Function
    Function getNombre() As String

        Return txtNombre.Text.Trim

    End Function
    Function getSalario() As String

        Return txtSalario.Text.Trim

    End Function
    Sub modificarJugador()
        objJugador.IDJUGADOR = getCodigo()
        objJugador.NOMBRE = getNombre()
        objJugador.SALARIO = getSalario()
        objNegocio.modificarJugadores(objJugador)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        modificarJugador()
    End Sub

End Class