Imports capaEntidad
Imports capaNegocio
Public Class NuevoProyecto




    Dim objProyecto As New CEProyecto
    Dim objNegocio As New CNProyecto
    Function getCodigo() As Integer
        Return txtCodigo.Text.Trim
    End Function
    Function getDesc() As String

        Return txtDescripcion.Text.Trim

    End Function
    Function getClub() As String

            Return txtClub.Text.Trim

        End Function
    Sub registroProyectos()
        objProyecto.IDPROYECTO = getCodigo()
        objProyecto.DESCRIPCION = getDesc()
        objProyecto.IDCLUB = getClub()
        objNegocio.registroProyectos(objProyecto)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroProyectos()
        Me.Close()
    End Sub

    Private Sub NuevoProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = objNegocio.generarCodigoProyecto
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.Close()
    End Sub
End Class