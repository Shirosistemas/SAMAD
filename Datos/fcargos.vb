Imports MySql.Data.MySqlClient
Public Class fcargos
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando
    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_cargos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'If cmd.ExecuteNonQuery Then 'Si la consulta contiene información

            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            da.Fill(dt) 'Retornamos el contenido al adaptador
            Return dt
            ' Else
            ' Return Nothing 'Retornamos nada
            ' End If
        Catch ex As Exception
            MsgBox("Mensaje2:" + ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            desconectado()
        End Try
    End Function
    Public Function insertar(ByVal dts As vCargos) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_cargos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vdescripcion", dts.gdescripcion)
            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("cargos", "Insertar", id, dts.gdescripcion)
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

    Public Function editar(ByVal dts As vCargos) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_cargos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gidcargo)
            cmd.Parameters.AddWithValue("vdescripcion", dts.gdescripcion)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("cargos", "Editar", dts.gidcargo, dts.gdescripcion)
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

    Public Function eliminar(ByVal dts As vCargos) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_cargos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gidcargo

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("cargos", "Eliminar", dts.gidcargo, "")
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
