﻿Imports capaNegocio
Public Class ListadoTrofeos

    Private Sub ListadoTrofeos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarTrofeos()
    End Sub


    Sub listarTrofeos()
        Dim objCapaNegocio As New CNTrofeo
        DataGridView1.DataSource = objCapaNegocio.listarTrofeos.Tables("TROFEOS")
        lblTotal.Text = objCapaNegocio.listarTrofeos.Tables("TROFEOS").Rows.Count
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
    End Sub
End Class