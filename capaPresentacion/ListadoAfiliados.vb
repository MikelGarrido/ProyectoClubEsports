﻿Imports capaNegocio
Public Class ListadoAfiliados

    Private Sub ListadoAfiliados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarAfiliados()
    End Sub


    Sub listarAfiliados()
            Dim objCapaNegocio As New CNAfiliado
        DataGridView1.DataSource = objCapaNegocio.listarAfiliados.Tables("AFILIADOS")
        lblTotal.Text = objCapaNegocio.listarAfiliados.Tables("AFILIADOS").Rows.Count
    End Sub



End Class