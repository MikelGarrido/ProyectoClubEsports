Imports capaNegocio
Public Class ListadoCompetir

    Private Sub ListadoCompetir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarCompetir()
    End Sub

    Sub listarCompetir()
        Dim objCapaNegocio As New CNCompetir
        DataGridView1.DataSource = objCapaNegocio.listarCompetir.Tables("COMPETIR")
        lblTotal.Text = objCapaNegocio.listarCompetir.Tables("COMPETIR").Rows.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class