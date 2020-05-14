Imports capaEntidad
Imports capaNegocio
Public Class NuevoEntrenador

    Dim objEntrenador As New CEEntrenador
    Dim objNegocio As New CNEntrenador
    Function getCodigo() As Integer
        Return txtCodigo.Text.Trim
    End Function
    Function getNombre() As String

        Return txtNombre.Text.Trim

    End Function
    Function getSalario() As Integer

        Return txtSalario.Text.Trim

    End Function

    Function getClub() As String

            Return txtClub.Text.Trim

        End Function
    Sub registroEntrenadores()
        objEntrenador.IDENTRENADOR = getCodigo()
        objEntrenador.NOMBRE = getNombre()
        objEntrenador.SALARIO = getSalario()
        objEntrenador.IDCLUB = getClub()
        objNegocio.registroEntrenadores(objEntrenador)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroEntrenadores()
    End Sub
    Private Sub NuevoEntrenador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = objNegocio.generarCodigoEntrenador
    End Sub
End Class