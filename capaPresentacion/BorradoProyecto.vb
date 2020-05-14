Imports capaEntidad
Imports capaNegocio
Public Class BorradoProyecto

    Dim objProyecto As New CEProyecto
    Dim objNegocio As New CNProyecto
    Function getCodigo() As Integer
        Return txtCodigo.Text
    End Function
    Sub borrarProyecto()
        objProyecto.IDPROYECTO = getCodigo()
        objNegocio.borrarProyectos(objProyecto)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        borrarProyecto()
    End Sub
End Class