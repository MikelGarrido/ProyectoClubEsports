Imports capaNegocio
Public Class ListadoJugadores
    Private Sub ListadoJugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarJugadores()
    End Sub

    Sub listarJugadores()
        Dim objCapaNegocio As New CNJugador
        DataGridView1.DataSource = objCapaNegocio.listarJugadores.Tables("JUGADORES")
        lblTotal.Text = objCapaNegocio.listarJugadores.Tables("JUGADORES").Rows.Count
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
    End Sub
End Class