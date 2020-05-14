Public Class Competiciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListadoCompeticiones.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NuevaCompeticion.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ModificarCompeticiones.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Show()
    End Sub
End Class