Imports MySql.Data.MySqlClient
Public Class forigenes
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_origenes") 'Llamamos al procedimiento almacenado
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

    Public Function insertar(ByVal dts As vOrigenes) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_origenes") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vlugar", dts.glugar)
            cmd.Parameters.AddWithValue("vdepartamento", dts.gdepartamento)
            cmd.Parameters.AddWithValue("vprovincia", dts.gprovincia)
            cmd.Parameters.AddWithValue("vdistrito", dts.gdistrito)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("origenes", "Insertar", id, dts.glugar)
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

    Public Function editar(ByVal dts As vOrigenes) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_origenes") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.goriid)
            cmd.Parameters.AddWithValue("vlugar", dts.glugar)
            cmd.Parameters.AddWithValue("vdepartamento", dts.gdepartamento)
            cmd.Parameters.AddWithValue("vprovincia", dts.gprovincia)
            cmd.Parameters.AddWithValue("vdistrito", dts.gdistrito)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("origenes", "Editar", dts.goriid, dts.glugar)
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

    Public Function eliminar(ByVal dts As vOrigenes) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_origenes") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.goriid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("origenes", "Eliminar", dts.goriid, "")
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
