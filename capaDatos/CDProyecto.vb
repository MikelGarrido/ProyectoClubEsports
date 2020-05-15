Imports System.Data.SqlClient
Imports capaEntidad
Public Class CDProyecto



    Dim objConection As New CDConection
        Dim da As SqlDataAdapter
        Dim cn As SqlConnection



    Function listarProyectos() As DataSet

        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_listarProyectos", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Proyectos")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try

    End Function
    Function generarCodigoProyecto() As Integer
        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_getUltCodigoProyectos", cn)
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

    Sub registroProyectos(ByVal obj As CEProyecto)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_crearProyecto", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDPROYECTO", SqlDbType.Int).Value = obj.IDPROYECTO
                .Add("@DESCRIPCION", SqlDbType.NVarChar).Value = obj.DESCRIPCION
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
    Sub borrarProyectos(ByVal obj As CEProyecto)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_borrarProyecto", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDPROYECTO", SqlDbType.Int).Value = obj.IDPROYECTO
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Proyecto eliminado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub
    Sub modificarProyectos(ByVal obj As CEProyecto)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_modificarProyecto", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDPROYECTO", SqlDbType.Int).Value = obj.IDPROYECTO
                .Add("@DESCRIPCION", SqlDbType.NVarChar).Value = obj.DESCRIPCION
                .Add("@IDCLUB", SqlDbType.NVarChar).Value = obj.IDCLUB
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Proyecto modificado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub



End Class
