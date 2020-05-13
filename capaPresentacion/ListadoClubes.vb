Imports capaNegocio
Public Class ListadoClubes
    Private Sub ListadoClubes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarClubes()
    End Sub

    Sub listarClubes()
        Dim objCapaNegocio As New CNClubes
        DataGridView1.DataSource = objCapaNegocio.listarClubes.Tables("CLUBES")
        lblTotal.Text = objCapaNegocio.listarClubes.Tables("CLUBES").Rows.Count
    End Sub
End Class
