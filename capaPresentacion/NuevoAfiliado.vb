Imports capaEntidad
Imports capaNegocio
Public Class NuevoAfiliado


    Dim objAfiliado As New CEAfiliado
    Dim objNegocio As New CNAfiliado
    Function getCodigo() As Integer
        Return txtCodigo.Text.Trim
    End Function
    Function getNombre() As String

        Return txtNombre.Text.Trim

    End Function
    Function getFecha() As String

        Return txtFecha.Text.Trim

    End Function
    Function getClub() As String

        Return txtClub.Text.Trim

    End Function
    Sub registroAfiliados()
        objAfiliado.IDAFILIADO = getCodigo()
        objAfiliado.NOMBRE = getNombre()
        objAfiliado.FECHAAF = getFecha()
        objAfiliado.IDCLUB = getClub()
        objNegocio.registroAfiliados(objAfiliado)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroAfiliados()
        Me.Close()
    End Sub

    Private Sub NuevoAfiliado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = objNegocio.generarCodigoAfiliado
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.Close()
    End Sub
End Class