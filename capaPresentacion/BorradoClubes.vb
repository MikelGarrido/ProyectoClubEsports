Imports capaEntidad
Imports capaNegocio
Public Class BorradoClubes


    Dim objClub As New CEClub
    Dim objNegocio As New CNClub
    Function getCodigo() As String
        Return txtCodigo.Text.Trim
    End Function
    Sub borrarClubes()
        objClub.IDCLUB = getCodigo()
        objNegocio.borrarClubes(objClub)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        borrarClubes()
    End Sub

    Private Sub BorradoClubes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class