﻿Public Class Trofeos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListadoTrofeos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ModificarTrofeo.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NuevoTrofeo.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        MenuInicio.Show()
    End Sub
End Class