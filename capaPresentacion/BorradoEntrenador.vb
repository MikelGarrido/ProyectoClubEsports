Imports capaEntidad
Imports capaNegocio
Public Class BorradoEntrenador


    Dim objEntrenador As New CEEntrenador
    Dim objNegocio As New CNEntrenador
    Function getCodigo() As Integer
            Return txtCodigo.Text
        End Function
    Sub borrarEntrenador()
        objEntrenador.IDENTRENADOR = getCodigo()
        objNegocio.borrarEntrenadores(objEntrenador)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        borrarEntrenador()
    End Sub

End Class