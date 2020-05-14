Imports System.Data.SqlClient
Imports capaEntidad
Public Class CDTrofeo



    Dim objConection As New CDConection
        Dim da As SqlDataAdapter
        Dim cn As SqlConnection



    Function listarTrofeos() As DataSet

        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_listarTrofeos", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Trofeos")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try

    End Function
    Function generarCodigoTrofeo() As Integer
        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_getUltCodigoTrofeo", cn)
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

    Sub registroTrofeos(ByVal obj As CETrofeo)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_crearTrofeo", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDTROFEO", SqlDbType.Int).Value = obj.IDTROFEO
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@JUEGO", SqlDbType.NVarChar).Value = obj.JUEGO
                .Add("@IDCLUB", SqlDbType.NVarChar).Value = obj.IDCLUB
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
    Sub modificarTrofeos(ByVal obj As CETrofeo)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_modificarTrofeo", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDTROFEO", SqlDbType.Int).Value = obj.IDTROFEO
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@JUEGO", SqlDbType.NVarChar).Value = obj.JUEGO
                .Add("@IDCLUB", SqlDbType.NVarChar).Value = obj.IDCLUB
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Trofeo modificado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub



End Class
