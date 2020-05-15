Public Class Entrenadores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListadoEntrenadores.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NuevoEntrenador.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BorradoEntrenador.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ModificarEntrenador.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        MenuInicio.Show()
    End Sub
End Class