Imports System.Data.SqlClient
Imports capaEntidad
Public Class CDJugador

    Dim objConection As New CDConection
    Dim da As SqlDataAdapter
    Dim cn As SqlConnection

    Function listarJugadores() As DataSet

        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_listarJugadores", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Jugadores")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try

    End Function
    Function generarCodigoJugador() As Integer
        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_getUltCodigoJugadores", cn)
            Dim r As Integer
            cn.Open()
            r = da.SelectCommand.ExecuteScalar
            Return r + 1
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try
    End Function

    Sub registroJugadores(ByVal obj As CEJugador)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_crearJugador", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDJUGADOR", SqlDbType.Int).Value = obj.IDJUGADOR
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@SALARIO", SqlDbType.Money).Value = obj.SALARIO
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Registro realizado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub
    Sub borrarJugadores(ByVal obj As CEJugador)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_borrarJugador", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDJUGADOR", SqlDbType.Int).Value = obj.IDJUGADOR
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Jugador eliminado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub
    Sub modificarJugadores(ByVal obj As CEJugador)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_modificarJugador", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDJUGADOR", SqlDbType.Int).Value = obj.IDJUGADOR
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@SALARIO", SqlDbType.Money).Value = obj.SALARIO
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Jugador modificado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub

End Class
