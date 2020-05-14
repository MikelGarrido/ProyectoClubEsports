Imports capaEntidad
Imports capaNegocio

Public Class ModificarClubes


    Dim objClub As New CEClub
    Dim objNegocio As New CNClub
    Function getCodigo() As String
        Return txtCodigo.Text.Trim
    End Function
    Function getNombre() As String

        Return txtNombre.Text.Trim

    End Function
    Sub modificarClubes()
        objClub.IDCLUB = getCodigo()
        objClub.NOMBRE = getNombre()
        objNegocio.modificarClubes(objClub)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        modificarClubes()
    End Sub

End Class