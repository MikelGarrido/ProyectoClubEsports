Imports System.Data.SqlClient
Imports capaEntidad
Public Class CDClub
    Dim objConection As New CDConection
    Dim da As SqlDataAdapter
    Dim cn As SqlConnection



    Function listarClubes() As DataSet

        Try
            cn = objConection.conectar
            da = New SqlDataAdapter("SP_listarClubes", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Clubes")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
        End Try

    End Function

    Sub registroClubes(ByVal obj As CEClub)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_crearClub", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDCLUB", SqlDbType.NVarChar).Value = obj.IDCLUB
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
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
    Sub borrarClubes(ByVal obj As CEClub)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_borrarClub", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDCLUB", SqlDbType.NVarChar).Value = obj.IDCLUB
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Club eliminado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub
    Sub modificarClubes(ByVal obj As CEClub)
        Try
            cn = objConection.conectar
            cn.Open()
            da = New SqlDataAdapter("SP_modificarClub", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IDCLUB", SqlDbType.NVarChar).Value = obj.IDCLUB
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NOMBRE
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("¡Club modificado con éxito!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub
End Class
