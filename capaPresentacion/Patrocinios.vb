Public Class Patrocinios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListadoPatrocinios.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NuevoPatrocinio.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BorradoPatrocinio.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class