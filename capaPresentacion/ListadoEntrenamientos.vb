﻿Imports capaNegocio
Public Class ListadoEntrenamientos

    Private Sub ListadoEntrenamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarEntrenamientos()
    End Sub

    Sub listarEntrenamientos()
        Dim objCapaNegocio As New CNEntrena
        DataGridView1.DataSource = objCapaNegocio.listarEntrenamientos.Tables("ENTRENA")
        lblTotal.Text = objCapaNegocio.listarEntrenamientos.Tables("ENTRENA").Rows.Count
    End Sub


End Class