Imports capaEntidad
Imports capaNegocio
Public Class NuevaCompeticion



    Dim objCompeticion As New CECompeticion
    Dim objNegocio As New CNCompeticion
    Function getCodigo() As Integer
            Return txtCodigo.Text.Trim
        End Function
        Function getNombre() As String

            Return txtNombre.Text.Trim

        End Function
    Function getFecha() As String

        Return txtFecha.Text.Trim

    End Function

    Function getJuego() As String

        Return txtJuego.Text.Trim

    End Function

    Sub registroCompeticiones()
        objCompeticion.IDCOMPETICION = getCodigo()
        objCompeticion.NOMBRE = getNombre()
        objCompeticion.FECHA = getFecha()
        objCompeticion.JUEGO = getJuego()
        objNegocio.registroCompeticiones(objCompeticion)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroCompeticiones()
        Me.Close()
    End Sub
    Private Sub NuevaCompeticion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = objNegocio.generarCodigoCompeticion
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.Close()
    End Sub
End Class