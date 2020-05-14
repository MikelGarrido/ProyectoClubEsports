Imports System.Data.SqlClient
Imports capaEntidad
Public Class CDPatrocinio


    Dim objConection As New CDConection
    Dim da As SqlDataAdapter
    Dim cn As SqlConnection



    Function listarPatrocinios() As DataSet

        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_listarPatrocinios", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Patrocinios")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try

    End Function
    Function generarCodigoPatrocinio() As Integer
        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_getUltCodigoPatrocinio", cn)
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

    Sub registroPatrocinios(ByVal obj As CEPatrocinio)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_crearPatrocinio", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDPATROCINIO", SqlDbType.Int).Value = obj.IDPATROCINIO
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@PAGO", SqlDbType.Money).Value = obj.PAGO
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
    Sub borrarPatrocinios(ByVal obj As CEPatrocinio)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_borrarPatrocinio", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDPATROCINIO", SqlDbType.Int).Value = obj.IDPATROCINIO
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Patrocinio eliminado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub
    Sub modificarPatrocinios(ByVal obj As CEPatrocinio)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_modificarPatrocinio", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDPATROCINIO", SqlDbType.Int).Value = obj.IDPATROCINIO
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@PAGO", SqlDbType.Money).Value = obj.PAGO
                .Add("@IDCLUB", SqlDbType.NVarChar).Value = obj.IDCLUB
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Patrocinio modificado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub


End Class
