Imports capaEntidad
Imports capaNegocio
Public Class ModificarTrofeo


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
    Sub modificarTrofeo()
        objTrofeo.IDTROFEO = getCodigo()
        objTrofeo.NOMBRE = getNombre()
        objTrofeo.JUEGO = getJuego()
        objTrofeo.IDCLUB = getClub()
        objNegocio.modificarTrofeos(objTrofeo)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        modificarTrofeo()
    End Sub

    Private Sub ModificarTrofeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class