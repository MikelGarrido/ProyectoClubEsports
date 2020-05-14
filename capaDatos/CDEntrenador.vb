Imports System.Data.SqlClient
Imports capaEntidad
Public Class CDEntrenador




    Dim objConection As New CDConection
        Dim da As SqlDataAdapter
        Dim cn As SqlConnection



    Function listarEntrenadores() As DataSet

        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_listarEntrenadores", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Entrenadores")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try

    End Function
    Function generarCodigoEntrenador() As Integer
        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_getUltCodigoEntrenadores", cn)
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

    Sub registroEntrenadores(ByVal obj As CEEntrenador)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_crearEntrenador", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDENTRENADOR", SqlDbType.Int).Value = obj.IDENTRENADOR
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@SALARIO", SqlDbType.Money).Value = obj.SALARIO
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
    Sub borrarEntrenadores(ByVal obj As CEEntrenador)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_borrarEntrenador", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDENTRENADOR", SqlDbType.Int).Value = obj.IDENTRENADOR
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Entrenador eliminado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub
    Sub modificarEntrenadores(ByVal obj As CEEntrenador)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_modificarEntreandor", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDENTRENADOR", SqlDbType.Int).Value = obj.IDENTRENADOR
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
                .Add("@SALARIO", SqlDbType.Money).Value = obj.SALARIO
                .Add("@IDCLUB", SqlDbType.NVarChar).Value = obj.IDCLUB
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Entrenador modificado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub

End Class
