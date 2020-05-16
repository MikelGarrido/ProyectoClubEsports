Imports System.Data.SqlClient
Imports capaEntidad
Public Class CDCompetir

    Dim objConection As New CDConection
        Dim da As SqlDataAdapter
        Dim cn As SqlConnection

    Function listarCompetir() As DataSet

        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_listarCompetir", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Competir")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try

    End Function

    Sub registroCompetir(ByVal obj As CECompetir)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_crearCompetir", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDJUGADOR", SqlDbType.Int).Value = obj.IDJUGADOR
                .Add("@IDCOMPETICION", SqlDbType.Int).Value = obj.IDCOMPETICION
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
    Sub borrarCompetir(ByVal obj As CECompetir)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_borrarCompetir", cn)
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
