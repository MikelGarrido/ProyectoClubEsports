Imports capaEntidad
Imports capaNegocio
Public Class ModificarCompeticiones


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
    Sub modificarCompeticion()
        objCompeticion.IDCOMPETICION = getCodigo()
        objCompeticion.NOMBRE = getNombre()
        objCompeticion.FECHA = getFecha()
        objCompeticion.JUEGO = getJuego()
        objNegocio.modificarCompeticiones(objCompeticion)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        modificarCompeticion()
        Me.Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
    End Sub
End Class