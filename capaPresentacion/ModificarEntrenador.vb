Imports capaEntidad
Imports capaNegocio
Public Class ModificarEntrenador

    Dim objEntrenador As New CEEntrenador
    Dim objNegocio As New CNEntrenador
    Function getCodigo() As Integer
        Return txtCodigo.Text.Trim
    End Function
    Function getNombre() As String

            Return txtNombre.Text.Trim

        End Function
    Function getSalario() As String

        Return txtSalario.Text.Trim

    End Function
    Function getClub() As String

            Return txtClub.Text.Trim

        End Function
    Sub modificarEntrenador()
        objEntrenador.IDENTRENADOR = getCodigo()
        objEntrenador.NOMBRE = getNombre()
        objEntrenador.SALARIO = getSalario()
        objEntrenador.IDCLUB = getClub()
        objNegocio.modificarEntrenadores(objEntrenador)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        modificarEntrenador()
        Me.Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
    End Sub
End Class