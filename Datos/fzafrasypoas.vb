Imports MySql.Data.MySqlClient
Public Class fzafrasypoas
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_zafrasypoas") 'Llamamos al procedimiento almacenado
            'cmd.CommandType = CommandType.TableDirect
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            da.Fill(dt) 'Retornamos el contenido al adaptador
            Return dt
            ' Else
            ' Return Nothing 'Retornamos nada
            ' End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vZafrasypoas) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_zafrasypoas") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vresolucion", dts.gzypresolucion)
            cmd.Parameters.AddWithValue("vtipopm", dts.gzyptipopm)
            cmd.Parameters.AddWithValue("vzafra", dts.gzypzafra)
            cmd.Parameters.AddWithValue("vpoa", dts.gzyppoa)
            cmd.Parameters.AddWithValue("vpermisoid", dts.gzyppermisoid)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("zafrasypoas", "Insertar", id, dts.gzypzafra.ToString() + "-" + dts.gzyppoa)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function editar(ByVal dts As vZafrasypoas) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_zafrasypoas") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vresolucion", dts.gzypresolucion)
            cmd.Parameters.AddWithValue("vtipopm", dts.gzyptipopm)
            cmd.Parameters.AddWithValue("vid", dts.gzypid)
            cmd.Parameters.AddWithValue("vzafra", dts.gzypzafra)
            cmd.Parameters.AddWithValue("vpoa", dts.gzyppoa)
            cmd.Parameters.AddWithValue("vpermisoid", dts.gzyppermisoid)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("zafrasypoas", "Editar", dts.gzypid, dts.gzypzafra + "-" + dts.gzyppoa)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function eliminar(ByVal dts As vZafrasypoas) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_zafrasypoas") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gzypid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("zafrasypoas", "Eliminar", dts.gzypid, "")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
