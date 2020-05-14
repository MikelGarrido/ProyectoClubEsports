Imports System.Data.SqlClient
Imports capaEntidad
Public Class CDCompeticion


    Dim objConection As New CDConection
    Dim da As SqlDataAdapter
    Dim cn As SqlConnection

    Function listarCompeticiones() As DataSet

        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_listarCompeticiones", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Competiciones")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try

    End Function
    Function generarCodigoCompeticion() As Integer
        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_getUltCodigoCompeticiones", cn)
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

    Sub registroCompeticiones(ByVal obj As CECompeticion)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_crearCompeticion", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDCOMEPTICION", SqlDbType.Int).Value = obj.IDCOMEPTICION
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@FECHA", SqlDbType.Money).Value = obj.FECHA
                .Add("@JUEGO", SqlDbType.Money).Value = obj.JUEGO
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
    Sub modificarCompeticiones(ByVal obj As CECompeticion)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_modificarCompeticion", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDCOMEPTICION", SqlDbType.Int).Value = obj.IDCOMEPTICION
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@FECHA", SqlDbType.Money).Value = obj.FECHA
                .Add("@JUEGO", SqlDbType.Money).Value = obj.JUEGO
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Competicion modificada con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub


End Class
