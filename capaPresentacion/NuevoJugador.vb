Imports capaEntidad
Imports capaNegocio
Public Class NuevoJugador


    Dim objJugador As New CEJugador
    Public IDJUGADOR As Integer
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
        Me.IDJUGADOR = getCodigo()
        objJugador.NOMBRE = getNombre()
        objJugador.SALARIO = getSalario()
        objNegocio.registroJugadores(objJugador)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroJugadores()
        Entrenamiento.Show()
    End Sub
    Private Sub NuevoJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = objNegocio.generarCodigoJugador
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.Close()
    End Sub
End Class