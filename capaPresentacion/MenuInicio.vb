Public Class MenuInicio
    Private Sub btnClubes_Click(sender As Object, e As EventArgs) Handles btnClubes.Click
        Clubes.Show()
    End Sub

    Private Sub btnAfiliados_Click(sender As Object, e As EventArgs) Handles btnAfiliados.Click
        Afiliados.Show()
    End Sub

    Private Sub btnPatrocinios_Click(sender As Object, e As EventArgs) Handles btnPatrocinios.Click
        Patrocinios.Show()
    End Sub

    Private Sub btnProyectos_Click(sender As Object, e As EventArgs) Handles btnProyectos.Click
        Proyectos.Show()
    End Sub

    Private Sub btnTrofeos_Click(sender As Object, e As EventArgs) Handles btnTrofeos.Click
        Trofeos.Show()
    End Sub

    Private Sub btnEntrenadores_Click(sender As Object, e As EventArgs) Handles btnEntrenadores.Click
        Entrenadores.Show()
    End Sub

    Private Sub btnEntrenamientos_Click(sender As Object, e As EventArgs) Handles btnEntrenamientos.Click
        ListadoEntrenamientos.Show()
    End Sub

    Private Sub btnJugadores_Click(sender As Object, e As EventArgs) Handles btnJugadores.Click
        Jugadores.Show()
    End Sub

    Private Sub btnCompetidas_Click(sender As Object, e As EventArgs) Handles btnCompetidas.Click
        Competidores.Show()
    End Sub
End Class