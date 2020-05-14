Imports capaEntidad
Imports capaNegocio

Public Class NuevoClub
    Dim objClub As New CEClub
    Dim objNegocio As New CNClub
    Function getCodigo() As String
        Return txtCodigo.Text.Trim
    End Function
    Function getNombre() As String

        Return txtNombre.Text.Trim

    End Function
    Sub registroClubes()
        objClub.IDCLUB = getCodigo()
        objClub.NOMBRE = getNombre()
        objNegocio.registroClubes(objClub)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroClubes()
    End Sub

    Private Sub NuevoClub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class