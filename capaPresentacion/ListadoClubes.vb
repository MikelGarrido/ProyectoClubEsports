Imports capaNegocio
Public Class ListadoClubes
    Private Sub ListadoClubes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarClubes()
    End Sub

    Sub listarClubes()
        Dim objCapaNegocio As New CNClub
        Me.DataGridView1.DataSource = objCapaNegocio.listarClubes.Tables("CLUBES")
        Me.lblTotal.Text = objCapaNegocio.listarClubes.Tables("CLUBES").Rows.Count
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
    End Sub
End Class
