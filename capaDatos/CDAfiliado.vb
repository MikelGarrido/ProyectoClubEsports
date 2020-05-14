Imports System.Data.SqlClient
Imports capaEntidad
Public Class CDAfiliado

    Dim objConection As New CDConection
        Dim da As SqlDataAdapter
        Dim cn As SqlConnection



    Function listarAfiliados() As DataSet

        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_listarAfiliados", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Afiliados")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try

    End Function
    Function generarCodigoAfiliado() As Integer
        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_getUltCodigoAfiliado", cn)
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

    Sub registroAfiliados(ByVal obj As CEAfiliado)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_crearAfiliado", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDAFILIADO", SqlDbType.Int).Value = obj.IDAFILIADO
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@FECHAAF", SqlDbType.NVarChar).Value = obj.FECHAAF
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
    Sub borrarAfiliados(ByVal obj As CEAfiliado)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_borrarAfiliado", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDAFILIADO", SqlDbType.Int).Value = obj.IDAFILIADO
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Afiliado eliminado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub
    Sub modificarAfiliados(ByVal obj As CEAfiliado)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_modificarAfiliado", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDAFILIADO", SqlDbType.Int).Value = obj.IDAFILIADO
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@FECHAAF", SqlDbType.NVarChar).Value = obj.FECHAAF
                .Add("@IDCLUB", SqlDbType.NVarChar).Value = obj.IDCLUB
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Afiliado modificado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub

End Class
