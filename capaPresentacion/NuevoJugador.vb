Imports capaEntidad
Imports capaNegocio
Public Class NuevoJugador


    Dim objJugador As New CEJugador
    Dim objNegocio As New CNJugador
    Function getCodigo() As Integer
            Return txtCodigo.Text.Trim
        End Function
        Function getNombre() As String

            Return txtNombre.Text.Trim

        End Function
        Function getSalario() As Integer

            Return txtSalario.Text.Trim

        End Function

    Sub registroJugadores()
        objJugador.IDJUGADOR = getCodigo()
        objJugador.NOMBRE = getNombre()
        objJugador.SALARIO = getSalario()
        objNegocio.registroJugadores(objJugador)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroJugadores()
    End Sub
    Private Sub NuevoJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = objNegocio.generarCodigoJugador
    End Sub

End Class