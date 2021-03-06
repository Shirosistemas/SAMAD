﻿Imports MySql.Data.MySqlClient
Public Class fpersonal
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_personal") 'Llamamos al procedimiento almacenado
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
            MsgBox(ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vPersonal) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_personal") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vpernomape", dts.gpernomape)
            cmd.Parameters.AddWithValue("vpercargoid", dts.gpercargoid)
            cmd.Parameters.AddWithValue("vpercargo", dts.gpercargo)
            cmd.Parameters.AddWithValue("vpercondicion", dts.gpercondicion)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("personal", "Insertar", id, dts.gpernomape)
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

    Public Function editar(ByVal dts As vPersonal) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_personal") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gperid)
            cmd.Parameters.AddWithValue("vpernomape", dts.gpernomape)
            cmd.Parameters.AddWithValue("vpercargoid", dts.gpercargoid)
            cmd.Parameters.AddWithValue("vpercargo", dts.gpercargo)
            cmd.Parameters.AddWithValue("vpercondicion", dts.gpercondicion)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("personal", "Editar", dts.gperid, dts.gpernomape)
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

    Public Function eliminar(ByVal dts As vPersonal) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_personal") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gperid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("personal", "Eliminar", dts.gperid, dts.gpernomape)
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
