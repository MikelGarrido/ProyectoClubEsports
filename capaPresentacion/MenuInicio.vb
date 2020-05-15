Public Class MenuInicio
    Private Sub btnClubes_Click(sender As Object, e As EventArgs) Handles btnClubes.Click
        Clubes.Show()
        Me.Hide()
    End Sub

    Private Sub btnAfiliados_Click(sender As Object, e As EventArgs) Handles btnAfiliados.Click
        Afiliados.Show()
        Me.Hide()
    End Sub

    Private Sub btnPatrocinios_Click(sender As Object, e As EventArgs) Handles btnPatrocinios.Click
        Patrocinios.Show()
        Me.Hide()
    End Sub

    Private Sub btnProyectos_Click(sender As Object, e As EventArgs) Handles btnProyectos.Click
        Proyectos.Show()
        Me.Hide()
    End Sub

    Private Sub btnTrofeos_Click(sender As Object, e As EventArgs) Handles btnTrofeos.Click
        Trofeos.Show()
        Me.Hide()
    End Sub

    Private Sub btnEntrenadores_Click(sender As Object, e As EventArgs) Handles btnEntrenadores.Click
        Entrenadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnEntrenamientos_Click(sender As Object, e As EventArgs) Handles btnEntrenamientos.Click
        ListadoEntrenamientos.Show()
        Me.Hide()
    End Sub

    Private Sub btnJugadores_Click(sender As Object, e As EventArgs) Handles btnJugadores.Click
        Jugadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnCompetidas_Click(sender As Object, e As EventArgs) Handles btnCompetidas.Click
        Competidores.Show()
        Me.Hide()
    End Sub

    Private Sub btnCompeticiones_Click(sender As Object, e As EventArgs) Handles btnCompeticiones.Click
        Competiciones.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Bienvenido.Close()
    End Sub
End Class