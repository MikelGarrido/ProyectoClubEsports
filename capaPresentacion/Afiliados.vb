Public Class Afiliados
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListadoAfiliados.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BorradoAfiliados.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NuevoAfiliado.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        MenuInicio.Show()
    End Sub
End Class