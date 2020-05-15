Imports capaNegocio
Public Class ListadoPatrocinios


    Private Sub ListadoPatrocinios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPatrocinios()
    End Sub


    Sub listarPatrocinios()
        Dim objCapaNegocio As New CNPatrocinio
        DataGridView1.DataSource = objCapaNegocio.listarPatrocinios.Tables("PATROCINIOS")
        lblTotal.Text = objCapaNegocio.listarPatrocinios.Tables("PATROCINIOS").Rows.Count
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
    End Sub
End Class