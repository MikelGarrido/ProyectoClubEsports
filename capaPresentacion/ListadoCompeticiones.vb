Imports capaNegocio
Public Class ListadoCompeticiones

    Private Sub ListadoCompeticiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarCompeticiones()
    End Sub

    Sub listarCompeticiones()
        Dim objCapaNegocio As New CNCompeticion
        DataGridView1.DataSource = objCapaNegocio.listarCompeticiones.Tables("COMPETICIONES")
        lblTotal.Text = objCapaNegocio.listarCompeticiones.Tables("COMPETICIONES").Rows.Count
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
    End Sub
End Class