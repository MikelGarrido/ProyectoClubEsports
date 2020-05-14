Imports capaEntidad
Imports capaNegocio
Public Class Entrenamiento


    Dim objEntrena As New CEEntrena
    Dim objNegocio As New CNEntrena

    Function getCodigoJugador() As Integer
        Return txtCodigoJugador.Text.Trim
    End Function
    Function getCodigoEntrenador() As String

        Return txtCodigoEntrenador.Text.Trim

    End Function

    Sub registroEntrenamiento()
        objEntrena.IDJUGADOR = getCodigoJugador()
        objEntrena.IDENTRENADOR = getCodigoEntrenador()
        objNegocio.registroEntrenamientos(objEntrena)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        registroEntrenamiento()
        Me.Close()
        NuevoJugador.Close()
    End Sub
    Private Sub Entrenamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigoJugador.Text = NuevoJugador.IDJUGADOR
        MsgBox("¡Ahora debe asignarle un entrenador a este nuevo jugador!", MsgBoxStyle.Information)
    End Sub
End Class