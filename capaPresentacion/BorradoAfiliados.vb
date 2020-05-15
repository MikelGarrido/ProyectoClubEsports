Imports capaEntidad
Imports capaNegocio
Public Class BorradoAfiliados



    Dim objAfiliado As New CEAfiliado
    Dim objNegocio As New CNAfiliado
    Function getCodigo() As String
            Return txtCodigo.Text.Trim
        End Function
    Sub borrarAfiliados()
        objAfiliado.IDAFILIADO = getCodigo()
        objNegocio.borrarAfiliados(objAfiliado)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        borrarAfiliados()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class