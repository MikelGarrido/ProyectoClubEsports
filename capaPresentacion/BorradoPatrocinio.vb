Imports capaEntidad
Imports capaNegocio
Public Class BorradoPatrocinio




    Dim objPatrocinio As New CEPatrocinio
    Dim objNegocio As New CNPatrocinio
    Function getCodigo() As Integer
        Return txtCodigo.Text
    End Function
    Sub borrarPatrocinio()
        objPatrocinio.IDPATROCINIO = getCodigo()
        objNegocio.borrarPatrocinios(objPatrocinio)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        borrarPatrocinio()
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class