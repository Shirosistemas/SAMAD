﻿Imports MySql.Data.MySqlClient
Public Class fclientes
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando
    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_clientes") 'Llamamos al procedimiento almacenado
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
    Public Function insertar(ByVal dts As vClientes) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_clientes") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vnomraz", dts.gnomraz)
            cmd.Parameters.AddWithValue("vtipodoc", dts.gtipodoc)
            cmd.Parameters.AddWithValue("vnumdoc", dts.gnumdoc)
            cmd.Parameters.AddWithValue("vdireccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("vtelefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("vcontacto", dts.gcontacto)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("clientes", "Insertar", id, dts.gnomraz)
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

    Public Function editar(ByVal dts As vClientes) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_clientes") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gclieid)
            cmd.Parameters.AddWithValue("vnomraz", dts.gnomraz)
            cmd.Parameters.AddWithValue("vtipodoc", dts.gtipodoc)
            cmd.Parameters.AddWithValue("vnumdoc", dts.gnumdoc)
            cmd.Parameters.AddWithValue("vdireccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("vtelefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("vcontacto", dts.gcontacto)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("clientes", "Editar", dts.gclieid, dts.gnomraz)
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

    Public Function eliminar(ByVal dts As vClientes) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_clientes") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gclieid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("clientes", "Eliminar", dts.gclieid, "")
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
