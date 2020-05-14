Imports capaEntidad
Imports capaNegocio
Public Class NuevoPatrocinio



    Dim objPatrocinio As New CEPatrocinio
    Dim objNegocio As New CNPatrocinio
    Function getCodigo() As Integer
        Return txtCodigo.Text.Trim
    End Function
    Function getNombre() As String

        Return txtNombre.Text.Trim

    End Function
    Function getPago() As Integer

        Return txtPago.Text.Trim

    End Function
    Function getClub() As String

        Return txtClub.Text.Trim

    End Function
    Sub registroPatrocinios()
        objPatrocinio.IDPATROCINIO = getCodigo()
        objPatrocinio.NOMBRE = getNombre()
        objPatrocinio.PAGO = getPago()
        objPatrocinio.IDCLUB = getClub()
        objNegocio.registroPatrocinios(objPatrocinio)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroPatrocinios()
    End Sub

    Private Sub NuevoPatrocinio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = objNegocio.generarCodigoPatrocinio
    End Sub
End Class