Imports MySql.Data.MySqlClient
Public Class fespecies
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_especies") 'Llamamos al procedimiento almacenado
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

    Public Function insertar(ByVal dts As vEspecies) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_especies") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vnombrecomun", dts.gnombre_comun)
            cmd.Parameters.AddWithValue("vnombrecientifico", dts.gnombre_cientifico)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("especies", "Insertar", id, dts.gnombre_comun)
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

    Public Function editar(ByVal dts As vEspecies) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_especies") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gidespecie)
            cmd.Parameters.AddWithValue("vnombrecomun", dts.gnombre_comun)
            cmd.Parameters.AddWithValue("vnombrecientifico", dts.gnombre_cientifico)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("especies", "Editar", dts.gidespecie, dts.gnombre_comun)
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

    Public Function eliminar(ByVal dts As vEspecies) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_especies") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gidespecie

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("especies", "Eliminar", dts.gidespecie, "")
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
