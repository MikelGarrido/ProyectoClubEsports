Imports capaEntidad
Imports capaNegocio
Public Class NuevoTrofeo

    Dim objTrofeo As New CETrofeo
    Dim objNegocio As New CNTrofeo
    Function getCodigo() As Integer
        Return txtCodigo.Text.Trim
    End Function
    Function getNombre() As String

            Return txtNombre.Text.Trim

        End Function
    Function getJuego() As String

        Return txtJuego.Text.Trim

    End Function
    Function getClub() As String

            Return txtClub.Text.Trim

        End Function
    Sub registroTrofeos()
        objTrofeo.IDTROFEO = getCodigo()
        objTrofeo.NOMBRE = getNombre()
        objTrofeo.JUEGO = getJuego()
        objTrofeo.IDCLUB = getClub()
        objNegocio.registroTrofeos(objTrofeo)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroTrofeos()
    End Sub

    Private Sub NuevoTrofeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = objNegocio.generarCodigoTrofeo
    End Sub
End Class