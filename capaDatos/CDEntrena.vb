Imports System.Data.SqlClient
Imports capaEntidad
Public Class CDEntrena

    Dim objConection As New CDConection
    Dim da As SqlDataAdapter
    Dim cn As SqlConnection

    Function listarEntrenamientos() As DataSet

        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_listarEntrenamientos", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Entrena")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try

    End Function

    Sub registroEntrenamiento(ByVal obj As CEEntrena)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_crearEntrenamiento", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDENTRENADOR", SqlDbType.Int).Value = obj.IDENTRENADOR
                .Add("@IDJUGADOR", SqlDbType.Int).Value = obj.IDJUGADOR
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
    Sub borrarEntrenamiento(ByVal obj As CEEntrena)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_borrarEntrenamiento", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDJUGADOR", SqlDbType.Int).Value = obj.IDJUGADOR
            End With
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub
End Class