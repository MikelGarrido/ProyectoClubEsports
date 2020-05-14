Imports capaNegocio
Public Class ListadoEntrenadores

    Private Sub ListadoEntrenadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarEntrenadores()
    End Sub

    Sub listarEntrenadores()
        Dim objCapaNegocio As New CNEntrenador
        DataGridView1.DataSource = objCapaNegocio.listarEntrenadores.Tables("ENTRENADORES")
        lblTotal.Text = objCapaNegocio.listarEntrenadores.Tables("ENTRENADORES").Rows.Count
    End Sub

End Class