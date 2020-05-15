Imports capaNegocio
Public Class ListadoProyectos

    Private Sub ListadoProyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProyectos()
    End Sub

    Sub listarProyectos()
        Dim objCapaNegocio As New CNProyecto
        DataGridView1.DataSource = objCapaNegocio.listarProyectos.Tables("PROYECTOS")
        lblTotal.Text = objCapaNegocio.listarProyectos.Tables("PROYECTOS").Rows.Count
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
    End Sub
End Class